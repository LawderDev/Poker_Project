using System.Collections.Generic;
using System.Windows.Forms;

namespace PokerProject
{
    public partial class DealManagement : Form
    {

        public Player Player { get; set; }
        public List<int> DealsOfWin { get; set; }
        public List<int> Moneys { get; set; }

        /// <summary>
        /// COnstructor of DealMangement
        /// </summary>
        /// <param name="Player">The player</param>
        public DealManagement(Player Player)
        {
            InitializeComponent();
            this.Player = Player;
            this.DealsOfWin = DealsOfWin;
            this.Moneys = new List<int>();
            this.DealsOfWin = new List<int>();
            labelHistory.Text += "\n" + Player.Name;
            initizalizeDealAndPot();
        }

        /// <summary>
        /// Initialize deals and pots
        /// </summary>
        public void initizalizeDealAndPot()
        {
            DealsOfWin.ForEach(d => listBox1.Items.Add(d));
            Moneys.ForEach(m => listBox2.Items.Add(m));
        }
    }
}
