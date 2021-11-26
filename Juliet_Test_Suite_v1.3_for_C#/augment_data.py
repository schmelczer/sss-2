import re
import glob
import os


def omit_cases(root: str, omit_good=False, omit_bad=False):
	def omit(name: str):
		for n in glob.glob(f'{root}/**/*.cs', recursive=True):
			with open(n, 'r+') as f:
				replaced = re.sub(rf'#if \(!OMIT{name}\).*?#endif.*?$', '',  f.read(), flags=re.DOTALL | re.MULTILINE)
				f.truncate(0)
				f.seek(0)
				f.write(replaced)
	if omit_good:
		omit('GOOD')
	if omit_bad:
		omit('BAD')


if __name__ == '__main__':
	os.system('cp -R src/ src-omit-good')
	omit_cases('src-omit-good', omit_good=True)

	os.system('cp -R src/ src-omit-bad')
	omit_cases('src-omit-bad', omit_bad=True)