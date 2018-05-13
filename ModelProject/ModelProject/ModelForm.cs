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
            GraphCount = 6;         // here!
            GraphList = new bool[GraphCount];

            selector.SetItemChecked(3, true);
            selector.SetItemChecked(4, true);
            confirmGraphsBtn_Click(this, new EventArgs());
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(indexUpDown.Value.ToString());
                int n = int.Parse(edtDivisionCounter.Text);
                var ex = new ExactSolution(n,
                                           double.Parse(edtHighestTemp.Text),
                                           double.Parse(edtPowerTemp.Text),
                                           double.Parse(edtRadius.Text));

                ex.Solve(index);

                var sc = new SchemeSolution(n,
                                        double.Parse(edtHighestTemp.Text),
                                        double.Parse(edtPowerTemp.Text),
                                        double.Parse(edtRadius.Text));
                sc.MScheme = double.Parse(mScheme.Text);
                sc.Solve(index);

                //var ss = new Schuster_Schwarzschild(n,
                //                            double.Parse(edtHighestTemp.Text),
                //                            double.Parse(edtPowerTemp.Text),
                //                            double.Parse(edtRadius.Text));
                //ss.Solve(index);

                // Table
                tab.RowCount = n + 1;
                for (int iz = 0; iz <= n; iz++)
                {
                    tab[0, iz].Value = iz.ToString();
                    tab[1, iz].Value = string.Format("{0:E5}", ex.Z[iz]);
                    tab[2, iz].Value = string.Format("{0:E5}", sc.K[iz]);
                    tab[3, iz].Value = string.Format("{0:E5}", ex.Up[iz]);

                    tab[4, iz].Value = string.Format("{0:E5}", ex.U[iz]);
                    tab[5, iz].Value = string.Format("{0:E5}", sc.U[iz]);

                    tab[6, iz].Value = string.Format("{0:E5}", ex.DivF[iz]);
                    tab[7, iz].Value = string.Format("{0:E5}", sc.DivF[iz]);
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

        private void SelectDataFromTable(int iColumn, int size, out double[] data)
        {
            data = new double[size + 1];
            for (int i = 0; i <= size; i++)
                data[i] = double.Parse(tab[iColumn, i].Value.ToString());
        }

        private void SelectDataFromTableByGraph(int iGraph, int iColumn, int size, out double[] data)
        {
            data = null;
            if (GraphList[iGraph])
                SelectDataFromTable(iColumn, size, out data);
        }

        private void ShowGraph()
        {
            try
            {
                int n = int.Parse(edtDivisionCounter.Text);

                SelectDataFromTable(1, n, out double[] Z);
                SelectDataFromTableByGraph(0, 3, n, out double[] Up);

                SelectDataFromTableByGraph(1, 4, n, out double[] Ue);
                SelectDataFromTableByGraph(2, 5, n, out double[] Us);

                SelectDataFromTableByGraph(3, 6, n, out double[] DFE);
                SelectDataFromTableByGraph(4, 7, n, out double[] DFS);

                // Chart
                foreach (var s in chart.Series)
                {
                    s.Points.Clear();
                }

                Draw(0, Z, Up);
                Draw(1, Z, Ue);
                Draw(2, Z, Us);
                Draw(3, Z, DFE);
                Draw(4, Z, DFS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnExeAll_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(edtDivisionCounter.Text);
                var ex = new ExactSolution(n,
                                           double.Parse(edtHighestTemp.Text),
                                           double.Parse(edtPowerTemp.Text),
                                           double.Parse(edtRadius.Text));

                ex.SolveAll();
                ex = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mScheme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int index = int.Parse(edtDivisionCounter.Text);
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
                        tab[4, iz].Value = sc.U[iz].ToString();
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

        private void confirmGraphsBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GraphCount; i++)
            {
                GraphList[i] = (selector.GetItemChecked(i)) ? true : false;
            }
        }
    }
}
