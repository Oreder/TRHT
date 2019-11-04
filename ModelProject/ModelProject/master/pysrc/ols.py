# Ordinary least squares extended
# Author: Binh D. Nguyen
# See more: https://en.wikipedia.org/wiki/Ordinary_least_squares

from math import *
import numpy as np

def __func__(x, A, n):
	return np.sum(a * pow(x, k) for a, k in zip(A, np.array([i for i in range(0, n + 1)])))

def sum_help(X, k):
	return np.sum(pow(x, k) for x in X)

def M_help(X, n):
	result = []	# np.array([])
	for k in range(0, 2 * n + 1):
		result = np.append(result, [sum_help(X, k)])
	return result
	
def sub_array_by_length(X, first_index, length):
	return X[first_index : (first_index + length + 1)]

def __M__(X, n):
	src = M_help(X, n)
	result = [sub_array_by_length(src, 0, n)]
	for i in range(1, n + 1):
		result = np.concatenate((result, [sub_array_by_length(src, i, n)]), axis=0)
	return result
	
def __B__(X, Y, n):
	result = [np.sum(Y)]	# np.array([])
	for k in range(1, n + 1):
		result = np.append(result, [np.sum(y * pow(x, k) for y, x in zip(Y, X))])
	return result
	
# Solution
def solve(X, Y, n):
	return np.linalg.solve(__M__(X, n), __B__(X, Y, n))

# mean error-function
def __merr__(X, Y, n):
	return np.sum(abs(y - __func__(x, solve(X, Y, n), n)) for y, x in zip(Y, X)) / len(Y)

# square of error-function
def __serr__(X, Y, n):
	return np.sum(pow(y - __func__(x, solve(X, Y, n), n), 2) for y, x in zip(Y, X)) / len(Y)

# Accuracy of our predicted function, using mean error-function
def __maccuracy__(X, Y, n):
	midY = np.sqrt(np.sum(pow(y, 2) for y in Y) / len(Y))
	return __merr__(X, Y, n) / midY
	
# Accuracy of our predicted function, using square error-function
def __saccuracy__(X, Y, n):
	midY = np.sqrt(np.sum(pow(y, 2) for y in Y) / len(Y))
	return np.sqrt(__serr__(X, Y, n)) / midY

# Get approximated array by applying OLS
def get_new_coordinates(X, Y, n):
	result = []	# np.array([])
	A = solve(X, Y, n)
	for k in range(0, len(X)):
		result = np.append(result, [__func__(X[k], A, n)])
	return result
	# vect = np.vectorize(__func__)
	# return vect(X, solve(X, Y, n), n)