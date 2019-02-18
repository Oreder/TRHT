using System;
using System.Windows.Forms;

namespace ModelProject
{
    public partial class ModelPro : Form
    {
        private int GraphCount { get; set; }
        private bool[] GraphList { get; set; }

        public ModelPro()
        {
            InitializeComponent();
            GraphCount = 8;         // here!
            GraphList = new bool[GraphCount];

            selector.SetItemChecked(3, true);
            selector.SetItemChecked(4, true);
        }

        /// <summary>
        /// Solution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(indexUpDown.Value.ToString());
                int __NZ = int.Parse(edtDivisionCounter.Text);
                double T0 = double.Parse(edtHighestTemp.Text);
                double M = double.Parse(edtPowerTemp.Text);
                double Radius = double.Parse(edtRadius.Text);

                //var ex = new ExactTest(__NZ, T0, M, Radius);
                var ex = new ExactSolution(__NZ, T0, M, Radius);
                ex.Solve(index);

                var sc = new SchemeSolution(__NZ, T0, M, Radius);
                sc.MScheme = double.Parse(mScheme.Text);
                sc.Solve(index);

                //var ss = new Schuster_Schwarzschild(n,
                //                            double.Parse(edtHighestTemp.Text),
                //                            double.Parse(edtPowerTemp.Text),
                //                            double.Parse(edtRadius.Text));
                //ss.Solve(index);                // Table
                tab.RowCount = __NZ + 1;
                for (int iz = 0; iz <= __NZ; iz++)
                {
                    tab[0, iz].Value = iz.ToString();

                    tab[1, iz].Value = string.Format("{0:E5}", ex.Z[iz]);
                    // New test for 18-02-2019
                    tab[2, iz].Value = string.Format("{0:E5}", ModelBase.GetTemperature(ex.Z[iz], T0, M));

                    tab[3, iz].Value = string.Format("{0:E5}", sc.K[iz]);
                    tab[4, iz].Value = string.Format("{0:E5}", ex.Up[iz]);

                    tab[5, iz].Value = string.Format("{0:E5}", ex.U[iz]);
                    tab[6, iz].Value = string.Format("{0:E5}", sc.U[iz]);

                    tab[7, iz].Value = string.Format("{0:E5}", ex.DivF[iz]);
                    tab[8, iz].Value = string.Format("{0:E5}", sc.DivF[iz]);
                }

                ShowGraph();

                ex = null;
                sc = null;
                //ss = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        #region Data Collecting
        /// <summary>
        /// Select data from table by given Column index 
        /// </summary>
        /// <param name="iColumn">Column index</param>
        /// <param name="size">Length of array</param>
        /// <param name="data">Result array</param>
        private void SelectDataFromTable(int iColumn, int size, out double[] data)
        {
            data = new double[size + 1];
            for (int i = 0; i <= size; i++)
                data[i] = double.Parse(tab[iColumn, i].Value.ToString());
        }

        /// <summary>
        /// Select data from table by given index of selected graph
        /// </summary>
        /// <param name="iGraph">Graph index</param>
        /// <param name="iColumn">Column index</param>
        /// <param name="size">Length of array</param>
        /// <param name="data">Result array</param>
        private void SelectDataFromTableByGraph(int iGraph, int iColumn, int size, out double[] data)
        {
            data = null;
            if (GraphList[iGraph])
                SelectDataFromTable(iColumn, size, out data);
        }
        #endregion

        #region Graphs
        /// <summary>
        /// Draw chart from given 2 lists of points
        /// </summary>
        /// <param name="iGraph"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        private void Draw(int iGraph, double[] X, double[] Y)
        {
            chart.Series[iGraph].Enabled = GraphList[iGraph];
            if (GraphList[iGraph])
            {
                chart.Series[iGraph].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart.Series[iGraph].BorderWidth = 2;

                for (int i = 0; i < X.Length; i++)
                {
                    chart.Series[iGraph].Points.AddXY(X[i], Y[i]);
                }
            }
        }

        private void ShowGraph()
        {
            try
            {
                // get selected graphs' list
                for (int i = 0; i < GraphCount; i++)
                {
                    GraphList[i] = (selector.GetItemChecked(i)) ? true : false;
                }

                // the last one will not be show here!
                selector.SetItemChecked(7, false);
                GraphList[7] = false;
                chart.Series[7].Enabled = GraphList[7];

                // collect data
                int n = int.Parse(edtDivisionCounter.Text);

                SelectDataFromTable(1, n, out double[] Z);
                SelectDataFromTableByGraph(0, 4, n, out double[] Up);

                SelectDataFromTableByGraph(1, 5, n, out double[] Ue);
                SelectDataFromTableByGraph(2, 6, n, out double[] Us);

                SelectDataFromTableByGraph(3, 7, n, out double[] DFE);
                SelectDataFromTableByGraph(4, 8, n, out double[] DFS);

                SelectDataFromTableByGraph(6, 9, n, out double[] Thread);

                // Clear chart
                foreach (var s in chart.Series)
                {
                    s.Points.Clear();
                }

                // Draw chart
                Draw(0, Z, Up);
                Draw(1, Z, Ue);
                Draw(2, Z, Us);
                Draw(3, Z, DFE);
                Draw(4, Z, DFS);
                Draw(5, null, null);
                Draw(6, Z, Thread);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        } 
        #endregion

        private void mScheme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int index = int.Parse(indexUpDown.Value.ToString());
                    int n = int.Parse(edtDivisionCounter.Text);
                    //Us = new double[n + 1];

                    var sc = new SchemeSolution(n,
                                            double.Parse(edtHighestTemp.Text),
                                            double.Parse(edtPowerTemp.Text),
                                            double.Parse(edtRadius.Text));
                    sc.MScheme = double.Parse(mScheme.Text);
                    sc.Solve(index);

                    for (int iz = 0; iz <= n; iz++)
                    {
                        tab[6, iz].Value = string.Format("{0:E5}", sc.U[iz]);
                        tab[8, iz].Value = string.Format("{0:E5}", sc.DivF[iz]);
                    }

                    ShowGraph();
                    sc = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        #region Analys
        private void analyseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // collect data
                int n = int.Parse(edtDivisionCounter.Text);
                SelectDataFromTable(5, n, out double[] Ue);
                SelectDataFromTable(7, n, out double[] DFE);

                var AC = new AnalysingCoefficient(Ue, DFE);
                double m = AC.FirstMethod(n,
                                          double.Parse(edtHighestTemp.Text),
                                          double.Parse(edtPowerTemp.Text),
                                          double.Parse(edtRadius.Text),
                                          int.Parse(indexUpDown.Value.ToString()));
                mScheme.Text = m.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void collectAnalysBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // initialize
                int __NZ = int.Parse(edtDivisionCounter.Text);
                double T0 = double.Parse(edtHighestTemp.Text);
                double M = double.Parse(edtPowerTemp.Text);
                double Radius = double.Parse(edtRadius.Text);

                //var ex = new ExactTest(__NZ, T0, M, Radius);
                var ex = new ExactSolution(__NZ, T0, M, Radius);

                //int MaxIndex = ex.NFreq - 1;          // HERE!!!
                int MaxIndex = int.Parse(indexUpDown.Value.ToString());
                double[] Freq = new double[MaxIndex + 1];
                double[] MS = new double[MaxIndex + 1];
                double[] Tau = new double[MaxIndex + 1];

                // main stuff: collecting mScheme       # found exception: 31-33
                for (int index = 0; index <= MaxIndex; index++)
                {
                    ex.Solve(index);
                    var AC = new AnalysingCoefficient(ex.U, ex.DivF);
                    double value = AC.FirstMethod(__NZ, T0, M, Radius, index);

                    Freq[index] = ex.Freq;
                    Tau[index] = ex.Tau;
                    MS[index] = value;
                    AC = null;
                }
                ex = null;

                // save m (analys) and tau to file
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"..//..//MT-reports//MT.txt"))
                {
                    for (int j = 0; j <= MaxIndex; j++)
                    {
                        file.Write("{0}\t{1}\t{2}\n", Freq[j], MS[j], Tau[j]);
                    }
                }

                // Graph
                // 1. Correct interface
                for (int i = 0; i < GraphCount; i++)
                {
                    selector.SetItemChecked(i, false);
                    GraphList[i] = false;
                    chart.Series[i].Enabled = GraphList[i];
                }

                selector.SetItemChecked(5, true);
                GraphList[5] = true;

                // 2. Clear old chart
                foreach (var s in chart.Series)
                {
                    s.Points.Clear();
                }

                // 3. Draw result
                Draw(5, Freq, MS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion

        #region Thread report # found at m = 0.15
        private void reportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // initialize
                int __NZ = int.Parse(edtDivisionCounter.Text);
                double T0 = double.Parse(edtHighestTemp.Text);
                double M = double.Parse(edtPowerTemp.Text);
                double Radius = double.Parse(edtRadius.Text);
                selector.SetItemChecked(6, true);

                double[] result = new double[__NZ + 1];
                var sc = new SchemeSolution(__NZ, T0, M, Radius);
                sc.MScheme = double.Parse(mScheme.Text);
                //sc.MScheme = 0.15;

                for (int i = 0; i < sc.NFreq; i++)
                {
                    sc.Solve(i);
                    for (int j = 0; j <= __NZ; j++)
                    {
                        result[j] += sc.DivF[j] * sc.dFreq;
                    }
                }

                for (int j = 0; j <= __NZ; j++)
                {
                    tab[9, j].Value = string.Format("{0:E5}", result[j]);
                }

                ShowGraph();
                sc = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion

        private void btnThreadbyFreq_Click(object sender, EventArgs e)
        {
            try
            {
                // initialize
                int __NZ = int.Parse(edtDivisionCounter.Text);
                double T0 = double.Parse(edtHighestTemp.Text);
                double M = double.Parse(edtPowerTemp.Text);
                double Radius = double.Parse(edtRadius.Text);
                selector.SetItemChecked(7, true);

                //int MaxIndex = 20;
                int MaxIndex = int.Parse(indexUpDown.Value.ToString());
                double[] Freq = new double[MaxIndex + 1];
                double[] deltaThread = new double[MaxIndex + 1];

                var sc = new SchemeSolution(__NZ, T0, M, Radius);
                //sc.MScheme = double.Parse(mScheme.Text);
                sc.MScheme = 0.866;

                // save m (analys) and tau to file
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"..//..//Thread//ThreadByFrequency.csv"))
                {
                    for (int i = 0; i <= MaxIndex; i++)
                    {
                        sc.Solve(i);
                        Freq[i] = sc.Freq;
                        deltaThread[i] = sc.F[__NZ] / sc.dFreq;
                        Console.WriteLine("{0}", deltaThread[i]);

                        // write to file
                        for (int j = 0; j < __NZ; j++)
                        {
                            file.Write("{0:E},", sc.F[j]);
                        }
                        file.WriteLine("{0:E}", sc.F[__NZ]);
                    }
                }

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"..//..//Thread//ThreadByFrequency.txt"))
                {
                    // X-axis
                    for (int j = 0; j <= MaxIndex; j++)
                    {
                        for (int i = 0; i <= __NZ; i++)
                        {
                            if (j == MaxIndex && i == __NZ)
                                file.WriteLine("{0:E}", 1.0);
                            else
                                file.Write("{0:E},", (double)i / __NZ);                        
                        }
                    }

                    // Y-axis
                    var modelBase = new ModelBase();
                    for (int j = 0; j <= MaxIndex; j++)
                    {
                        for (int i = 0; i <= __NZ; i++)
                        {
                            if (j == MaxIndex && i == __NZ)
                                file.WriteLine("{0:E}", (modelBase.Frequency[MaxIndex + 1] + modelBase.Frequency[MaxIndex]) / 2.0);
                            else
                                file.Write("{0:E},", (modelBase.Frequency[j + 1] + modelBase.Frequency[j]) / 2.0);
                        }
                    }
                    modelBase = null;

                    // Z-axis
                    for (int j = 0; j <= MaxIndex; j++)
                    {
                        sc.Solve(j);
                        for (int i = 0; i <= __NZ; i++)
                        {
                            if (j == MaxIndex && i == __NZ)
                                file.WriteLine("{0:E}", sc.F[__NZ]);
                            else
                                file.Write("{0:E},", sc.F[i]);
                        }
                    }
                }
                sc = null;

                // Graph
                // 1. Correct interface
                for (int i = 0; i < GraphCount; i++)
                {
                    selector.SetItemChecked(i, false);
                    GraphList[i] = false;
                    chart.Series[i].Enabled = GraphList[i];
                }

                selector.SetItemChecked(7, true);
                GraphList[7] = true;

                // 2. Clear old chart
                foreach (var s in chart.Series)
                {
                    s.Points.Clear();
                }

                // 3. Draw result
                Draw(7, Freq, deltaThread);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
