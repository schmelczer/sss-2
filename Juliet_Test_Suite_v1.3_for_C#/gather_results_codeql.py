import csv
from pprint import pformat
from collections import Counter
from pathlib import Path
from typing import List, Tuple, Dict
import logging


logging.basicConfig(level=logging.INFO)


def evaluate_results(root: Path):
    results = gather_results(root)
    counters = get_cumulative_error_counts(results)
    covered_counts = get_covered_file_counts(root, results)
    evaluated = {
        "path": str(root),
        "found": counters,
        "file_count": all,
        "covered_counts": covered_counts
    }
    logging.info(pformat(evaluated))
    return evaluated


def gather_results(root: Path) -> List[Tuple[str, str, str, str]]:
    code_ql_csv_fields = ['Name', 'Description', 'Severity', 'Message', 'File', 'Start line', 'Start column', 'End line', 'End column']
    all_errors = []

    for i, n in enumerate(root.glob('**/results.csv')):
        logging.debug(f'reading ({i}): {n}')

        with open(n, 'r') as f:
            findings = csv.DictReader(f, fieldnames=code_ql_csv_fields)
            processed = [
                (r['Severity'], r['Name'], r['Description'], r['File']) for r in findings
            ]
            all_errors.extend(processed)

    return all_errors


def get_cumulative_error_counts(results: List[Tuple[str, str, str, str]]) -> Dict[str, Counter]:
    return {
        severity: Counter(n for s, n, d, f in results if s == severity)
        for severity in list({s for s, n, d, f in results})
    }


def has_omit_good_bad(path: Path) -> Tuple[bool, bool]:
    with open(path) as f:
        content = f.read()

    return [
        '#if (!OMITGOOD)' in content,
        '#if (!OMITBAD)' in content
    ]


def get_covered_file_counts(root: Path, results: List[Tuple[str, str, str, str]]) -> Dict[str, int]:
    omit_good_files = [f.name for f in (root / 'testcases').glob('**/*.cs') if has_omit_good_bad(f)[0]]
    omit_bad_files = [f.name for f in (root / 'testcases').glob('**/*.cs') if has_omit_good_bad(f)[1]]
    
    covered_with_error = {f.split('/')[-1] for s, n, d, f in results if s == 'error' and n != 'Container contents are never accessed'}
    covered_with_anything = {f.split('/')[-1] for s, n, d, f in results}
    return {
        'omit_good_files': {
            'all': len(omit_good_files),
            'covered_with_error': len(omit_good_files and covered_with_error),
            'covered_with_anything': len(omit_good_files and covered_with_anything)
        },
        'omit_bad_files': {
            'all': len(omit_bad_files),
            'covered_with_error': len(omit_bad_files and covered_with_error),
            'covered_with_anything': len(omit_bad_files and covered_with_anything)
        }
    }


def precision(tp, fp):
    return tp / (tp + fp)


def recall(tp, fn):
    return tp / (tp + fn)


def f1(p, r):
    return 2 * p * r / (p + r)


if __name__ == '__main__':
    omit_good_evaluations = evaluate_results(Path('src-omit-good'))
    omit_bad_evaluations = evaluate_results(Path('src-omit-bad'))

    real_positives = omit_good_evaluations['covered_counts']['omit_bad_files']['all']
    real_negatives = omit_bad_evaluations['covered_counts']['omit_good_files']['all']

    true_positives_errors = omit_good_evaluations['covered_counts']['omit_bad_files']['covered_with_error']
    false_negatives_errors = real_positives - true_positives_errors
    false_positives_errors = omit_bad_evaluations['covered_counts']['omit_good_files']['covered_with_error']
    true_negatives_errors = real_negatives - false_positives_errors

    precision_errors = precision(true_positives_errors, false_positives_errors)
    recall_errors = recall(true_positives_errors, false_negatives_errors)
    f1_error = f1(precision_errors, recall_errors)
    logging.info(f'With errors: {precision_errors:.2f} precision, {recall_errors:.2f} recall, {f1_error:.2f} F1')

    true_positives_anything = omit_good_evaluations['covered_counts']['omit_bad_files']['covered_with_anything']
    false_negatives_anything = real_positives - true_positives_anything
    false_positives_anything = omit_bad_evaluations['covered_counts']['omit_good_files']['covered_with_anything']
    true_negatives_anything = real_negatives - false_positives_anything

    precision_anything = precision(true_positives_anything, false_positives_anything)
    recall_anything = recall(true_positives_anything, false_negatives_anything)
    f1_anything = f1(precision_anything, recall_anything)
    logging.info(f'With anything: {precision_anything:.2f} precision, {recall_anything:.2f} recall, {f1_anything:.2f} F1')
