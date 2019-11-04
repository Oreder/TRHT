# Check function: P(z) = exp(az^2 + bz + c)
from math import *
import numpy as np
import matplotlib.pyplot as plt

# TEST DATA 1
X = [ 0.00,  0.05,  0.10,  0.15,  0.20,  0.25,  0.30,  0.35,  0.40,  0.45,  0.50,  0.55, 0.60, 0.65, 0.70, 0.75, 0.80, 0.85, 0.90, 0.95, 1.00]
Y = [30000, 29989, 29540, 29205, 28956, 28403, 27899, 27181, 26000, 23305, 18990, 14392, 9530, 5900, 3593, 2999, 2512, 2311, 2012, 2005, 2000]

# # TEST DATA 2
# X = [ 0.00,  0.05,  0.10,  0.15,  0.20,  0.25,  0.30,  0.35,  0.40,  0.45,  0.50,  0.55,  0.60,  0.65,  0.70,  0.75,  0.80,  0.85, 0.90, 0.95, 1.00]
# Y = [30000, 29999, 29996, 29989, 29981, 29970, 29957, 29939, 29917, 29875, 29839, 29777, 29403, 29001, 28101, 25112, 21052, 13917, 7912, 4371, 3000]

# # # TEST DATA 3 (exact)
# X = np.linspace(0, 1, 20)
# vect = np.vectorize(f1)
# Y = vect(X, 30000, -28000, 10.0)

# # TEST DATA 4
# X = [ 0.00,  0.05,  0.10,  0.15,  0.20,  0.25,  0.30,  0.35,  0.40,  0.45,  0.50,  0.55,  0.60,  0.65,  0.70,  0.75,  0.80,  0.85,  0.90,  0.95, 1.00]
# Y = [30000, 29999, 29996, 29989, 29981, 29970, 29957, 29939, 29917, 29875, 29839, 29777, 29603, 29425, 29223, 29032, 28752, 27031, 25139, 17912, 3000]

X = np.asarray(X)
Y = np.asarray(Y)

A = [Y[0], Y[-1] - Y[0]]

def f(z, a, b, c):
	return np.exp(a * pow(z, 2) + b * z + c)

# Using zip to calculate sum of arrays
m_11 = np.sum(np.power(X, 4))
m_12 = np.sum(np.power(X, 3))
m_13 = np.sum(np.power(X, 2))

m_21 = m_12
m_22 = m_13
m_23 = np.sum(X)

m_31 = m_13
m_32 = m_23
m_33 = len(X)

b_1 = np.sum(np.log(ty) * pow(tx, 2) for ty, tx in zip(Y, X))
b_2 = np.sum(np.log(ty) * tx for ty, tx in zip(Y, X))
b_3 = np.sum(np.log(ty) for ty in Y)

M = np.array([[m_11, m_12, m_13],
			  [m_21, m_22, m_23],
			  [m_31, m_32, m_33]])
			 
B = np.array([b_1, b_2, b_3])

# Solution
A = np.linalg.solve(M, B)

# Build up our figure
vect = np.vectorize(f)
newY = vect(X, A[0], A[1], A[2])

# Draw source data
print(A)

plt.scatter(X, Y)
plt.plot(X, Y, label='Original')

plt.scatter(X, newY)
plt.plot(X, newY, label='Approximated')

plt.legend()
# plt.savefig('05.png', dpi=720)
plt.show()