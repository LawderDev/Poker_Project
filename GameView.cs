using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PokerProject
{
    /// <summary>
    /// A simple game view. WinForms, but Console-like :
    /// one textbox for command input,
    /// one listbox to provide text feedback.
    /// </summary>
    public partial class GameView : Form
    {
        #region private attributes
        /// <summary>
        /// Not used at the start of the project, may be used for
        /// accessing public information ONLY.
        /// </summary>
        private readonly RuleSet theRules;
        private List<PlayerView> playerViews;
        private bool deplace;
        private bool infoWin;
        private PlayerView selection;
        private List<string> strGameInfo;
        #endregion
        #region constructor
        /// <summary>
        /// Standard parameter'd constructor.
        /// </summary>
        /// <param name="theRules">A reference to the RuleSet object used.</param>
        public GameView(RuleSet theRules)
        {
            InitializeComponent();
            DoubleBuffered = true;
            roundLabel.Text = "";
            this.theRules = theRules;
            InitInfosPlayer();
            deplace = false;
            selection = null;
            this.infoWin = false;
            this.strGameInfo = new List<string>();
        }
        #endregion
        #region public methods callable by the controller
        /// <summary>
        /// Initialize players informations for playerViews
        /// </summary>
        private void InitInfosPlayer()
        {
            int y = 30;
            int x;
            int numberPlayer = 0;

            playerViews = new List<PlayerView>();
            foreach (Player p in theRules.AllPlayers)
            {
                if (theRules.AllPlayers.IndexOf(p) != 0)
                {
                    y += 230;
                }
                numberPlayer++;
                if (numberPlayer == 4 || numberPlayer == 8)
                    y = 30;
                if (numberPlayer > 3)
                    x = 500;
                else if (numberPlayer > 7)
                    x = 900;
                else if (numberPlayer > 9)
                    x = 1300;
                else
                    x = 200;
                PlayerView player = new PlayerView(p, new Point(x, y), 10, new Size(60, 35));

                playerViews.Add(player);
            }
        }

        /// <summary>
        /// 1 - Example of a different display
        /// </summary>
        /// <param name="text">To be displayed</param>
        public void ChangeRoundLabel(string text) => roundLabel.Text = text;

        /// <summary>
        /// Method used for the text-based interface in order to display information.
        /// </summary>
        /// <param name="line">The line of text to be displayed.</param>
        public void WriteLine(string line)
        {
            if (!line.Contains("Possible actions are:"))
                strGameInfo.Add(line);
            if (line.Contains("Possible actions are: discard "))
                strGameInfo.Add("Discard is possible!");
        }
        #endregion
        #region event handling methods
        #endregion
        /// <summary>
        /// Manage and update graphics elements
        /// </summary>
        /// <param name="sender">The object</param>
        /// <param name="e">The event</param>
        private void GameView_Paint(object sender, PaintEventArgs e)
        {
            if (theRules.HumanPlayer && strGameInfo.Count != 0)
            {
                GameInformation gameInfo = new GameInformation(strGameInfo);
                strGameInfo.Clear();
                gameInfo.ShowDialog();

            }

            foreach (PlayerView p in playerViews)
            {
                if (theRules.HumanPlayer && !theRules.OtherPlayers.Contains(p.player))
                {
                    p.CurentPlayer = true;
                }
                else
                {
                    p.CurentPlayer = false;
                }
                p.Draw(e.Graphics);
            }
            e.Graphics.DrawString("Deal: " + theRules.Deal, new Font("Carlito", 10, FontStyle.Bold), Brushes.White, new Point(650, 10));
            e.Graphics.DrawString("Pot: " + theRules.Pot, new Font("Carlito", 10, FontStyle.Bold), Brushes.White, new Point(750, 10));

            if (theRules.Round != Rule.MayDrawDown && theRules.Round != Rule.MayDrawUp)
                buttonDiscard.Enabled = false;
            else
                buttonDiscard.Enabled = true;
        }

        /// <summary>
        /// Do actions specify when we click with the mouse
        /// </summary>
        /// <param name="sender">The object</param>
        /// <param name="e">The event</param>
        private void GameView_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (PlayerView p in playerViews)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (p.containsPlayerView(e.Location))
                    {
                        infoWin = true;
                        selection = p;
                        deplace = true;
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    foreach (PlayerView current in playerViews)
                    {
                        if (current.CurentPlayer)
                        {
                            if (p.containsPlayerView(e.Location) && p != current)
                            {
                                Cheat cheat = new Cheat(p.player, current.player);
                                cheat.ShowDialog();
                                Refresh();
                            }

                        }
                    }
                }
            }
            if (deplace == false && e.Button == MouseButtons.Left)
            {
                Automatisation();
            }
        }

        /// <summary>
        /// Do specifics action when we moove the mouse
        /// </summary>
        /// <param name="sender">The object</param>
        /// <param name="e">The event</param>
        private void GameView_MouseMove(object sender, MouseEventArgs e)
        {
            if (deplace && selection != null)
            {
                infoWin = false;
                selection.Coordinate = e.Location;
                Refresh();
            }
        }

        /// <summary>
        /// Do specifics actions when we release with button of the mouse
        /// </summary>
        /// <param name="sender">The object</param>
        /// <param name="e">The event</param>
        private void GameView_MouseUp(object sender, MouseEventArgs e)
        {
            if (deplace)
            {
                if (selection != null)
                {
                    selection.Coordinate = e.Location;
                    Refresh();
                }
                deplace = false;
            }
            if(infoWin && selection != null)
            {
                foreach (DealManagement d in GameControler.dealManagements)
                {
                    if (d.Player.Equals(selection.player))
                        d.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Open the dialog for discard a card
        /// </summary>
        /// <param name="sender">The object</param>
        /// <param name="e">The event</param>
        private void buttonDiscard_Click(object sender, System.EventArgs e)
        {
            foreach (PlayerView p in playerViews)
            {
                if (p.CurentPlayer)
                {
                    Discard discard = new Discard(p.player.Hand);
                    discard.ShowDialog();
                }
            }


        }

        /// <summary>
        /// Automatisation of actions who don't need the player.
        /// </summary>
        private void Automatisation()
        {
            foreach (PlayerView p in playerViews)
            {
                if (theRules.Round == Rule.Ante && p.CurentPlayer)
                {
                    GameControler.Interpret("ante");
                }
                if ((theRules.Round == Rule.DealCardDown || theRules.Round == Rule.DealCardUp || theRules.Round == Rule.MayDrawDown || theRules.Round == Rule.MayDrawDown || theRules.Round == Rule.DealCardCommon) && p.CurentPlayer)
                {
                    GameControler.Interpret("next");
                }
            }
            Refresh();

        }
    }
}