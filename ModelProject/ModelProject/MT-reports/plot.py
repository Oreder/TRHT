import numpy as np
import matplotlib.pyplot as plt
 
# Create data
x = []
y = []
low = []
high = []

for line in open("report.txt", 'r').readlines():
	src = [float(value) for value in line.split(' ')]
	if len(src) > 1:
		for value in src[1:]:
			x.append(src[0])
			y.append(value)
		low.append([src[0], min(src[1:])])
		high.append([src[0], max(src[1:])])

colors = (0,0,0)
area = np.pi*3
low = np.array(low)
high = np.array(high)

# Set figure name
plt.figure(num='Report')

# Plot points
plt.scatter(x, y, s=area, c=colors, alpha=0.5)

# Plot low and high lines (full)
plt.plot(low[:,0], low[:,1], 'ro-', color='green')
plt.plot(high[:,0], high[:,1], 'ro-', color='red')

# Plor low and high lines (except the last point)
# plt.plot(low[:-1,0], low[:-1,1], 'ro-', color='green')
# plt.plot(high[:-1,0], high[:-1,1], 'ro-', color='red')

plt.title('Scatter plot M(Tau)')
plt.xlabel('Tau')
plt.ylabel('M')
plt.show()