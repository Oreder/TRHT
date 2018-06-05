import numpy as np
import matplotlib.pyplot as plt
 
# Create data
x = []
y = []
for line in open("report.txt", 'r').readlines():
	src = [float(value) for value in line.split(' ')]
	if len(src) > 1:
		for value in src[1:]:
			x.append(src[0])
			y.append(value)

colors = (0,0,0)
area = np.pi*3
 
# Plot
plt.scatter(x, y, s=area, c=colors, alpha=0.5)
plt.title('Scatter plot M(Tau)')
plt.xlabel('Tau')
plt.ylabel('M')
plt.show()