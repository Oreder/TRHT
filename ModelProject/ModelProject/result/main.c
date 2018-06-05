#include <stdio.h>
#define MAX_SIZE 193

int main(int argc, char **argv)
{
	int ret = -1;
	FILE *fs = fopen(argv[1], "r");
	if (fs)
	{
		ret = 0;
		int index = 0;
		double f[MAX_SIZE], m[MAX_SIZE], t[MAX_SIZE];
		
		while (!feof(fs))
		{
			fscanf(fs, "%lf%lf%lf", &f[index], &m[index], &t[index]);
			index++;
		}
		fclose(fs);
		
		double max_t = t[0];
		fs = fopen("report.txt", "w");
		double tau[11] = {0.01, 0.1, 0.3, 0.5, 1.0, 1.5, 2.0, 3.0, 5.0, 8.0, 10.0};
		
		for (int j = 0; j < 11; j++)
		{
			fprintf(fs, "%5f\t", tau[j]);
			for (int k = 0; k < index - 1; k++)
			{
				// find max at the first loop
				if (j == 0)
				{
					if (t[k+1] > max_t)
						max_t = t[k+1];
				}
				else if (tau[j] > max_t)
					break;
				
				if ((tau[j] >= t[k]) && (tau[j] < t[k+1]))
				{
					// applying linear interpolation
					double g = (tau[j] - t[k]) / (t[k+1] - t[k]);
					double value = m[k] + g * (m[k+1] - m[k]);
					fprintf(fs, "%9f\t", value);
				}
			}
			if (j < 10)
				fprintf(fs, "\n");
		}
		fclose(fs);
	}
	return ret;
}