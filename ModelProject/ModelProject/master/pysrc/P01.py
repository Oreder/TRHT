# Program using method golden section search

from math import *
import numpy as np
import matplotlib.pyplot as plt

def f1(z, a0, a1, n1):
	return a0 + a1 * pow(z, n1)

def f(z, A, N):
	return np.sum(ta * pow(z, tn) for ta, tn in zip(A, N))

# # TEST DATA 1
# X = [ 0.00,  0.05,  0.10,  0.15,  0.20,  0.25,  0.30,  0.35,  0.40,  0.45,  0.50,  0.55, 0.60, 0.65, 0.70, 0.75, 0.80, 0.85, 0.90, 0.95, 1.00]
# Y = [30000, 29989, 29540, 29205, 28956, 28403, 27899, 27181, 26000, 23305, 18990, 14392, 9530, 5900, 3593, 2999, 2512, 2311, 2012, 2005, 2000]
# X = np.asarray(X)
# Y = np.asarray(Y)

# TEST DATA 2
X = [ 0.00,  0.05,  0.10,  0.15,  0.20,  0.25,  0.30,  0.35,  0.40,  0.45,  0.50,  0.55,  0.60,  0.65,  0.70,  0.75,  0.80,  0.85, 0.90, 0.95, 1.00]
Y = [30000, 29999, 29996, 29989, 29981, 29970, 29957, 29939, 29917, 29875, 29839, 29777, 29403, 29001, 28101, 25112, 21052, 13917, 7912, 4371, 3000]
# X = np.asarray(X)
# Y = np.asarray(Y)

# # TEST DATA 3 (exact)
X = np.linspace(0, 1, 20)
vect = np.vectorize(f1)
Y = vect(X, 30000, -28000, 10.0)

# TEST DATA 4
X = [ 0.00,  0.05,  0.10,  0.15,  0.20,  0.25,  0.30,  0.35,  0.40,  0.45,  0.50,  0.55,  0.60,  0.65,  0.70,  0.75,  0.80,  0.85,  0.90,  0.95, 1.00]
Y = [30000, 29999, 29996, 29989, 29981, 29970, 29957, 29939, 29917, 29875, 29839, 29777, 29603, 29425, 29223, 29032, 28752, 27031, 25139, 17912, 3000]

A = [Y[0], Y[-1] - Y[0]]

# Build up our minimized-function
def phi(n):
	vect = np.vectorize(f1)
	return np.sum(pow(ty - tz, 2.0) for ty, tz in zip(Y, vect(X, A[0], A[1], n)))
	
# Method Golden-section search applying for only phi()
def gss(a, b, tol=1e-5):
	gr = (sqrt(5) + 1) / 2	# golden ratio
	
	c = b - (b - a) / gr
	d = a + (b - a) / gr
	while abs(c - d) > tol:
		if phi(c) < phi(d):
			b = d
		else:
			a = c
			
		# Now we compute both c and d here to avoid loss of precision which may lead to incorrect results or infinite loop
		c = b - (b - a) / gr
		d = a + (b - a) / gr
		
	return (a + b) / 2

# Setup data
n1 = 0.0
n2 = 1000.0

# Solution
n = gss(n1, n2)

vect = np.vectorize(f1)
newY = vect(X, A[0], A[1], n)

print("Output: N = ", n, '\tError: ', phi(n))

# Get data of Phi(n)
_N = np.linspace(0.0, 20.0, num=500)
vect = np.vectorize(phi)
_P = vect(_N)

extPoint = (n, phi(n))

# Settings graphic
plt.xlabel("X")
plt.ylabel("Y")
plt.grid(True)

# Draw section
plt.title("Golden-section searching")
plt.scatter(X, Y)
plt.plot(X, Y, label='Original')

plt.scatter(X, newY)
plt.plot(X, newY, label = 'Approximated by GSS')

plt.legend()
plt.savefig('12.png', dpi=720)
plt.show()

# Phi-function graphic
plt.xlabel("N")
plt.ylabel("Phi(N)")
plt.grid(True)

plt.plot(_N, _P)
plt.plot(extPoint[0], extPoint[1], 'ro')
plt.annotate('min', 
			 extPoint,
			 xytext=(10, 10),
             textcoords='offset points',
             ha="right", va="bottom",
            )
plt.savefig('13.png', dpi=720)
plt.show()