using System;
using System.Windows.Forms;

namespace PokerProject
{
    public partial class Cheat : Form
    {
        private Player player;
        private Player currentPlayer;
        /// <summary>
        /// The constructor of cheat form
        /// </summary>
        /// <param name="player">The player</param>
        /// <param name="currentPlayer">The current player</param>
        public Cheat(Player player, Player currentPlayer)
        {
            InitializeComponent();
            this.player = player;
            this.currentPlayer = currentPlayer;
        }

        /// <summary>
        /// Show the card of the player
        /// </summary>
        public void showCards()
        {
            if (listBox1.Items.Count != player.Hand.Count)
            {
                player.Hand.ForEach(c => listBox1.Items.Add(c));
            }
            Refresh();
        }

        /// <summary>
        /// Transfer a random number of money of a player to the current palyer
        /// </summary>
        public void giveMoney()
        {
            Random rand = new Random();
            int numberRandom = rand.Next(0, player.Money);
            player.Spend(numberRandom);
            currentPlayer.Gain(numberRandom);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showCards();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giveMoney();
        }
    }
}
