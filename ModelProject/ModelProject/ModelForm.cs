using System;
using System.Windows.Forms;

namespace ModelProject
{
    public partial class ModelPro : Form
    {
        private int gCount { get; set; }
        private bool[] graph { get; set; }

        public ModelPro()
        {
            InitializeComponent();
            graph = new bool[5] { false, false, true, true, false };
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

                //var sc = new SchemeSolution(n,
                //                            double.Parse(edtHighestTemp.Text),
                //                            double.Parse(edtPowerTemp.Text),
                //                            double.Parse(edtRadius.Text));
                //sc.MScheme = double.Parse(mScheme.Text);
                //sc.Solve();

                var sc = new SchemeTest(n,
                                        double.Parse(edtHighestTemp.Text),
                                        double.Parse(edtPowerTemp.Text),
                                        double.Parse(edtRadius.Text));
                sc.MScheme = double.Parse(mScheme.Text);
                sc.Solve(index);

                var ss = new Schuster_Schwarzschild(n,
                                            double.Parse(edtHighestTemp.Text),
                                            double.Parse(edtPowerTemp.Text),
                                            double.Parse(edtRadius.Text));
                ss.Solve(index);

                // Table
                tab.RowCount = n + 1;
                for (int iz = 0; iz <= n; iz++)
                {
                    tab[0, iz].Value = iz.ToString();
                    tab[1, iz].Value = ex.Z[iz].ToString();
                    tab[2, iz].Value = ex.Up[iz].ToString();
                    tab[3, iz].Value = ex.U[iz].ToString();
                    tab[4, iz].Value = sc.U[iz].ToString();
                    tab[5, iz].Value = ss.U[iz].ToString();

                    //tab[2, iz].Value = sc.Z[iz].ToString();
                    //tab[3, iz].Value = ex.Up[iz].ToString();
                    //tab[4, iz].Value = sc.GetUp(index)[iz].ToString();
                    //tab[5, iz].Value = ex.U[iz].ToString();
                    //tab[6, iz].Value = sc.GetU(index)[iz];
                    //tab[7, iz].Value = ss.U[iz].ToString();
                    Console.WriteLine("{0:E}", ex.U[iz]);
                }

                ShowGraph();

                //double[] MS = new double[]
                ex = null;
                sc = null;
                ss = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Draw(int iGraph, double X, double Y)
        {
            if (graph[iGraph])
            {
                chart.Series[iGraph].Points.AddXY(X, Y);
                chart.Series[iGraph].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart.Series[iGraph].BorderWidth = 2;
            }
        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var g = new Navigation.Graph();
            g.ShowDialog();

            gCount = g.GraphCount;
            graph = g.GraphList;

            ShowGraph();
            //g.Close();
        }

        private double[] Z { get; set; }
        private double[] Up { get; set; }
        private double[] Ue { get; set; }
        private double[] Us { get; set; }
        private double[] Un { get; set; }

        private void ShowGraph()
        {
            try
            {
                int n = int.Parse(edtDivisionCounter.Text);
                Z = new double[n + 1];
                Up = new double[n + 1];
                Ue = new double[n + 1];
                Us = new double[n + 1];
                Un = new double[n + 1];

                for (int iz = 0; iz <= n; iz++)
                {
                    Z[iz] = double.Parse(tab[1, iz].Value.ToString());
                    Up[iz] = double.Parse(tab[2, iz].Value.ToString());
                    Ue[iz] = double.Parse(tab[3, iz].Value.ToString());
                    Us[iz] = double.Parse(tab[4, iz].Value.ToString());
                    Un[iz] = double.Parse(tab[5, iz].Value.ToString());
                }

                // Chart
                foreach (var s in chart.Series)
                {
                    s.Points.Clear();
                }

                for (int iz = 0; iz <= n; iz++)
                {
                    Draw(0, Z[iz], Up[iz]);
                    Draw(1, Z[iz], Ue[iz]);
                    Draw(2, Z[iz], Us[iz]);
                    Draw(3, Z[iz], Un[iz]);
                    //if (graph[4]) Draw(4, ex.Z[iz], ex.Up[iz]);
                }
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

                    var sc = new SchemeTest(n,
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
    }
}
