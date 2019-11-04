import ols
import bplotlib as bp
import numpy as np

__eps__ = 1e-1
# __eps__ = 1e-2

def f(z, a0, a1, n1):
	return a0 + a1 * pow(z, n1)

# TEST DATA X
X = np.array([ 0.00,  0.05,  0.10,  0.15,  0.20,  0.25,  0.30,  0.35,  0.40,  0.45,  0.50,  0.55, 0.60, 0.65, 0.70, 0.75, 0.80, 0.85, 0.90, 0.95, 1.00])	# np.linspace(0, 1, 20) 

# TEST DATA Y
# # 1 
# Y = [30000, 29989, 29540, 29205, 28956, 28403, 27899, 27181, 26000, 23305, 18990, 14392, 9530, 5900, 3593, 2999, 2512, 2311, 2012, 2005, 2000]

# # 2
# Y = [30000, 29999, 29996, 29989, 29981, 29970, 29957, 29939, 29917, 29875, 29839, 29777, 29403, 29001, 28101, 25112, 21052, 13917, 7912, 4371, 3000]

# # 3
# vect = np.vectorize(f)
# Y = vect(X, 30000, -28000, 10.0)

# # 4
# Y = [30000, 29999, 29996, 29989, 29981, 29970, 29957, 29939, 26917, 20875, 20039, 19777, 19603, 19425, 19223, 19032, 18752, 18031, 13934, 4912, 3000]

# 5
Y = np.random.uniform(low=2000, high=30000, size=(X.size,))

n = 1
while (ols.__maccuracy__(X, Y, n) > __eps__) and (n < len(X) - 1):
	n += 1

print("Optimized degree of polynomial is", n, ". Current accuracy is", ols.__maccuracy__(X, Y, n), ols.__saccuracy__(X, Y, n))

print(ols.solve(X, Y, n))
bp.show(X, Y, ols.get_new_coordinates(X, Y, n), 1, ".//For report 3/51.png")