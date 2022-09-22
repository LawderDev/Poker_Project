using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PokerProject
{
    public partial class GameInformation : Form
    {
        private List<string> lines;
        public GameInformation(List<string> lines)
        {
            InitializeComponent();
            this.lines = lines;
            this.lines.ForEach(l => listBox1.Items.Add(l));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
