using System;
using System.Windows.Forms;

namespace ModelProject.Navigation
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
            GraphCount = 5;         // here!
            GraphList = new bool[GraphCount];
            selector.SetItemChecked(1, true);
            selector.SetItemChecked(2, true);
        }

        public int GraphCount { get; set; }
        public bool[] GraphList { get; set; }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < GraphCount; i++)
            {
                GraphList[i] = (selector.GetItemChecked(i)) ? true : false;
            }
            Close();
        }
    }
}
