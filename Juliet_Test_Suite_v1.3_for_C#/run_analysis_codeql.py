#
# Example that shows how to run an analysis with an example tool.
#
# This script uses the run_analysis method from py_common.  The run_analysis method
# script finds all the build.xml files and then passes them to the function defined
# in this file.
#
# In this case, we compile each CWE's testcases using the ant build.xml file.
#

import sys, os

# add parent directory to search path so we can use py_common
sys.path.append("..")

import py_common

codeql_path = '/Users/andras/Desktop/Projects/sss-2/codeql/codeql'


def run_example_tool(bat_file):
	py_common.run_commands([
		'pwd',
		f'{codeql_path} database create codeql.db --language=csharp',
		f'{codeql_path} database analyze codeql.db csharp-lgtm-full.qls --format=csv --output=results.csv --threads=0',
		'rm -rf codeql.db'
	], use_shell=True)


if __name__ == '__main__':
	py_common.run_analysis(os.path.join("src-omit-good", "testcases"), "build\.bat", run_example_tool)
	py_common.run_analysis(os.path.join("src-omit-bad", "testcases"), "build\.bat", run_example_tool)
