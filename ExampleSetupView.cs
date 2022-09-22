using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PokerProject
{
    /// <summary>
    /// Example of a possible dialog for setup.
    /// </summary>
    public partial class ExampleSetupView : Form
    {
        private List<TextBox> thePlayers;
        #region attributes 
        private static List<CheckBox> theCheckBoxes;
        private readonly RuleSet theRules;
        #endregion
        #region Constructor
        /// <summary>
        /// Standard parameter'd constructor.
        /// </summary>
        /// <param name="theRules">Reference to the RuleSet object to use and initialize.</param>
        public ExampleSetupView(RuleSet theRules)
        {
            InitializeComponent();
            theCheckBoxes = new List<CheckBox>();
            this.theRules = theRules;
            thePlayers = new List<TextBox>();
            theRules.AvailableGames.ForEach(r => listBoxChoice.Items.Add(r));
            numericUpDownPlayers.Maximum = 0;
        }
        #endregion
        #region Event handling private methods
        private void ListBoxChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = listBoxChoice.SelectedItem.ToString();
            theRules.SetGame(choice); // Necessary before the other information is inferred.

            numericUpDownPlayers.Minimum = theRules.MinPlayers;
            numericUpDownPlayers.Maximum = theRules.MaxPlayers;
            // Maximum cap'd by the actual number of controls.
        }

        private void ExampleSetupView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NumericUpDownPlayers_ValueChanged(object sender, EventArgs e)
        {
            int nb = (int)numericUpDownPlayers.Value;
            int xLocation = 95;
            int yLocationText = 130;
            int yLocationBox = 203;
            theCheckBoxes.ForEach(c => this.Controls.Remove(c));
            theCheckBoxes.Clear();
            thePlayers.ForEach(p => this.Controls.Remove(p));
            thePlayers.Clear();
            for (int i = 1; i <= nb ; i++)
            {

                if (i == 7)
                {
                    yLocationText += 20;
                    xLocation = 95;
                    yLocationBox += 30;

                }
                CheckBox c = new CheckBox();
                c.ForeColor = Color.White;
                c.Size = new Size(82,17);
                c.Location = new Point(xLocation, yLocationText);
                c.Name = "checkBoxP" + i;
                c.Text = "P" + i + " Human?";
                if (i == 1)
                {
                    c.Checked = true;
                }
                
                theCheckBoxes.Add(c);
                this.Controls.Add(c);

                TextBox p = new TextBox();
                p.BackColor = Color.FromArgb(60, 60, 60);
                p.ForeColor = Color.White;
                p.Width = 70;
                p.Location= new Point(xLocation-10, yLocationBox);
                p.Name = "TextBoxName" + i;

                xLocation += 85;
                thePlayers.Add(p);
                this.Controls.Add(p);
                Refresh();

            }


            for (int i = 0; i < theCheckBoxes.Count; i++)
            {
                theCheckBoxes[i].Enabled = i < nb; // True for players selected, false for all others.
            }
        }
        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void ButtonValidate_Click(object sender, EventArgs e)
        {
            // nb players
            int nb = (int)numericUpDownPlayers.Value;

            // types of players
            string types ="";
            for (int i = 0; i < nb; i++)
            {
                    types += theCheckBoxes[i].Checked ? "H" : "A";
            }
            // names of players - TODO
           
            string names = "";
            for (int i = 0; i < thePlayers.Count; i++)
            {
                if(thePlayers[i].Text != "")
                {
                    if (i != 0 && names[names.Length-1] != ' ')
                    {
                        names += " ";
                    }
                    names += thePlayers[i].Text; 
                }
            }


            // ante and doubles - TODO
            string ante = numericUpDownAnte.Value.ToString();
            string doubles = "";
            if (checkBoxDouble.Checked)
                doubles = "yes";
            else
                doubles = "no";
            Console.WriteLine(doubles);

            // validation
            if (theRules.GameName==null || theRules.GameName.Equals(""))
            {
                MessageBox.Show("Issue: Game Choice");
            }
            else if (!theRules.SetNumberOfPlayers(nb.ToString()))
            {
                MessageBox.Show("Issue: Nb Players");
            }
            else if (!theRules.SetPlayerTypes(types))
            {
                MessageBox.Show("Issue: type of Players");
            }
            else if (!theRules.SetPlayerNames(names))
            {
                MessageBox.Show("Issue: names of Players");
            }
            else if (!theRules.SetAnte(ante))
            {
                MessageBox.Show("Issue: ante");
            }
            else if (!theRules.SetAnteDoubles(doubles))
            {
                MessageBox.Show("Issue: ante doubles");
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
        #endregion


    }
}
