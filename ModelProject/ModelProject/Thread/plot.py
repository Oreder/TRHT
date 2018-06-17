from mpl_toolkits.mplot3d import Axes3D
import matplotlib.pyplot as plt
from matplotlib import cm
import numpy as np
import pandas as pd

# read data
x = []
y = []
z = []
with open("ThreadByFrequency.txt", 'r') as file:
	x = [float(value) for value in file.readline().split(',')]
	y = [float(value) for value in file.readline().split(',')]
	z = [float(value) for value in file.readline().split(',')]

# N = 81 * 125
# x = x[N:]
# y = y[N:]
# z = z[N:]
	
x = np.array(x)
y = np.array(y)
z = np.array(z)
df = pd.DataFrame({'x': x, 'y': y, 'z': z})

# set up figure
fig = plt.figure()
ax = Axes3D(fig)
ax.set_xlabel('X')
ax.set_ylabel('Frequency')
ax.set_zlabel('Thread')
fig.canvas.set_window_title("Thread By Frequency")

# plot surface
ax.scatter(x, y, z, c='black', marker='o')
surf = ax.plot_trisurf(df.x, df.y, df.z, cmap=cm.jet, linewidth=1)
fig.colorbar(surf, shrink=0.5, aspect=5)

plt.show()