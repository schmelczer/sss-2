import csv
import glob


def gather_results(root: str):
    for n in glob.glob(f'{root}/**/results.csv', recursive=True):
        print(f'reading {n}')
        with open(n, 'r') as f:
            fields = csv.DictReader(f)

        print(fields)


gather_results('src-omit-good')