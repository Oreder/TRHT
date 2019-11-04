# Custom plot library
# Author: Binh D. Nguyen

import matplotlib.pyplot as plt

def show(X, Y, Z, saveFlag=0, fileName="United.png", dpi=720):
	plt.scatter(X, Y)
	plt.plot(X, Y, label="Source")

	plt.scatter(X, Z)
	plt.plot(X, Z, label="Approximated")
	
	plt.grid(True)
	plt.legend()
	
	if saveFlag != 0:
		plt.savefig(fname=fileName, dpi=dpi)
	
	plt.show()