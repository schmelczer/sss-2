#!/bin/sh

set -e

cd Juliet_Test_Suite_v1.3_for_C#

python3 run_analysis_codeql.py
python3 gather_results_codeql.py > ../code-ql-results.log

cd -