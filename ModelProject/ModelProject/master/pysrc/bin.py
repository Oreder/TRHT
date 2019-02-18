# Check function: P(z) = a0 + a1.z^n1 + a2.z^n2
from math import *
import numpy as np
import matplotlib.pyplot as plt

def f(z, a0, a1, n1, a2, n2):
	return a0 + a1 * pow(z, n1) + a2 * pow(z, n2)

# TEST DATA
X = [ 0.05,  0.10,  0.15,  0.20,  0.25,  0.30,  0.35,  0.40,  0.45,  0.50,  0.55,  0.60,  0.65,  0.70,  0.75, 0.80, 0.85, 0.90, 0.95, 1.00]
Y = [30000, 29540, 28705, 28056, 27203, 25899, 23181, 20000, 19305, 18990, 18392, 17530, 16900, 13593, 11999, 9312, 6812, 4012, 3500, 3000]
X = np.asarray(X)
Y = np.asarray(Y)

# Settings graphic
plt.xlabel("X")
plt.ylabel("Y")
plt.grid(True)

# test symlog
# plt.plot(x, y - y.mean())
# plt.yscale('symlog', linthreshy=0.01)

# Setup n1, n2
n2 = 100.0
d = 200.0
n1 = n2 - d

err = 1000000000
newY = []
_N1 = n1
_N2 = n2
_A = []

for i in range(0, int(d * 10) - 1):
	n1 = n1 + 0.1
	
	# Using zip to calculate sum of arrays
	m_11 = len(X)
	m_12 = np.sum(np.power(X, n1))
	m_13 = np.sum(np.power(X, n2))

	m_21 = m_12
	m_22 = np.sum(np.power(X, 2 * n1))
	m_23 = np.sum(np.power(X, n1 + n2))

	m_31 = m_13
	m_32 = m_23
	m_33 = np.sum(np.power(X, 2 * n2))

	b_1 = np.sum(Y)
	b_2 = np.sum(ty * pow(tx, n1) for ty, tx in zip(Y, X))
	b_3 = np.sum(ty * pow(tx, n2) for ty, tx in zip(Y, X))

	M = np.array([[m_11, m_12, m_13],
				  [m_21, m_22, m_23],
				  [m_31, m_32, m_33]])
				 
	B = np.array([b_1, b_2, b_3])

	# Solution
	A = np.linalg.solve(M, B)

	# Build up our figure
	vect = np.vectorize(f)
	new_err = np.sum(pow(ty - tz, 2.0) for ty, tz in zip(Y, vect(X, A[0], A[1], n1, A[2], n2)))
	if new_err < err:
		err = new_err
		newY = vect(X, A[0], A[1], n1, A[2], n2)
		_N1 = n1
		_N2 = n2
		_A = A
	
	# print("N1 = ", n1, '\tN2 = ', n2, '\terror: ', new_err)
	
# Draw source data
print("Output: N1 = ", _N1, '\tN2 = ', _N2, '\terror: ', err)
print(_A)

plt.title("Modeling data")
plt.scatter(X, Y)
plt.plot(X, Y)

plt.scatter(X, newY)
plt.plot(X, newY)

# plt.savefig('05.png', dpi=720)
plt.show()