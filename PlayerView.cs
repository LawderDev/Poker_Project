using System.Drawing;
using System.IO;

namespace PokerProject
{
    class PlayerView
    {
        public Player player { get; }
        public Point Coordinate { get; set; }
        public bool CurentPlayer { get; set; }
        private int thickness;
        private Size size;

        /// <summary>
        /// The constructor of the playerView
        /// </summary>
        /// <param name="player">The player</param>
        /// <param name="coordinate">The coordinate</param>
        /// <param name="thickness">The thickness</param>
        /// <param name="size">The size</param>
        public PlayerView(Player player, Point coordinate, int thickness, Size size)
        {
            this.player = player;
            this.Coordinate = coordinate;
            this.thickness = thickness;
            this.size = size;
            CurentPlayer = false;
        }

        /// <summary>
        /// Manage graphics elements
        /// </summary>
        /// <param name="g">The graphics</param>
        public void Draw(Graphics g)
        {
            Pen blackPen = new Pen(Brushes.Black);
            switch (player.PlayerStatus)
            {
                case PlayerStatus.In:
                    g.DrawRectangle(blackPen, Coordinate.X - 10, Coordinate.Y, 7, 7);
                    g.FillRectangle(Brushes.Red, Coordinate.X - 10, Coordinate.Y, 7, 7);
                    break;
                case PlayerStatus.OutDeal:
                    g.DrawEllipse(blackPen, Coordinate.X - 10, Coordinate.Y, 7, 7);
                    g.FillEllipse(Brushes.Blue, Coordinate.X - 10, Coordinate.Y, 7, 7);
                    break;
                case PlayerStatus.OutGame:
                    Point[] triangle = new Point[3];
                    triangle[0] = new Point(Coordinate.X - 13, Coordinate.Y);
                    triangle[1] = new Point(Coordinate.X - 10, Coordinate.Y + 7);
                    triangle[2] = new Point(Coordinate.X - 7, Coordinate.Y);
                    g.DrawPolygon(blackPen, triangle);
                    g.FillPolygon(Brushes.Black, triangle);
                    break;
            }
            g.DrawString(player.Name + " " + player.PlayerType + " " + player.PlayerStatus, new Font("Carlito", thickness, FontStyle.Bold), Brushes.White, Coordinate);
            g.DrawString("Money: " + player.Money.ToString(), new Font("Carlito", thickness, FontStyle.Bold), Brushes.White, new Point(Coordinate.X, Coordinate.Y + 20));
            int xCards = Coordinate.X;
            int yCards = Coordinate.Y + 45;
            int cpt = 0;

            if (CurentPlayer)
            {
                if (player.Hand.Count != 0)
                {
                    DrawCards(cpt, xCards, yCards, g, true);
                }
            }
            else
            {
                DrawCards(cpt, xCards, yCards, g, false);
            }
        }

        /// <summary>
        /// Retrieve the image of the card specify
        /// </summary>
        /// <param name="c">The Card</param>
        /// <returns>The image of the card</returns>
        private Image ImageCards(Card c)
        {
            Image img = Image.FromFile(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\CardsImage\\AceOfHearts.png");
            if (c.ToString().Contains("Hearts"))
            {
                img = RetrieveImage("Hearts", c);
            }
            if (c.ToString().Contains("Spades"))
            {
                img = RetrieveImage("Spades", c);
            }
            if (c.ToString().Contains("Clubs"))
            {
                img = RetrieveImage("Clubs", c);
            }
            if (c.ToString().Contains("Diamonds"))
            {
                img = RetrieveImage("Diamonds", c);
            }
            return img;
        }

        /// <summary>
        /// Retrieve the image of the card specify thanks to the type
        /// </summary>
        /// <param name="type">The type</param>
        /// <param name="card">The card</param>
        /// <returns></returns>
        private Image RetrieveImage(string type, Card card)
        {
            Image img = Image.FromFile(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\CardsImage\\AceOfHearts.png");
            if (card.ToString().Contains("Ace"))
                img = Image.FromFile(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\CardsImage\\AceOf" + type + ".png");
            if (card.ToString().Contains("Two"))
                img = Image.FromFile(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\CardsImage\\TwoOf" + type + ".png");
            if (card.ToString().Contains("Three"))
                img = Image.FromFile(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\CardsImage\\ThreeOf" + type + ".png");
            if (card.ToString().Contains("Four"))
                img = Image.FromFile(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\CardsImage\\FourOf" + type + ".png");
            if (card.ToString().Contains("Five"))
                img = Image.FromFile(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\CardsImage\\FiveOf" + type + ".png");
            if (card.ToString().Contains("Six"))
                img = Image.FromFile(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\CardsImage\\SixOf" + type + ".png");
            if (card.ToString().Contains("Seven"))
                img = Image.FromFile(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\CardsImage\\SevenOf" + type + ".png");
            if (card.ToString().Contains("Eight"))
                img = Image.FromFile(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\CardsImage\\EightOf" + type + ".png");
            if (card.ToString().Contains("Nine"))
                img = Image.FromFile(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\CardsImage\\NineOf" + type + ".png");
            if (card.ToString().Contains("Ten"))
                img = Image.FromFile(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\CardsImage\\TenOf" + type + ".png");
            if (card.ToString().Contains("Jack"))
                img = Image.FromFile(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\CardsImage\\JackOf" + type + ".png");
            if (card.ToString().Contains("Queen"))
                img = Image.FromFile(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\CardsImage\\QueenOf" + type + ".png");
            if (card.ToString().Contains("King"))
                img = Image.FromFile(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\CardsImage\\KingOf" + type + ".png");
            return img;

        }

        /// <summary>
        /// Draw all cards of a player
        /// </summary>
        /// <param name="cpt">the number of cards</param>
        /// <param name="xCards">The x Coordinate</param>
        /// <param name="yCards">The y Coordinate</param>
        /// <param name="g">The Graphics</param>
        /// <param name="current">Current player or not</param>
        private void DrawCards(int cpt, int xCards, int yCards, Graphics g, bool current)
        {
            size.Height = 130;
            size.Width = 0;
            foreach (Card c in player.Hand)
            {

                cpt++;
                if (cpt == 5)
                {
                    yCards += 85;
                    size.Height += 90;
                    xCards = Coordinate.X;
                }
                else
                {
                    size.Width += 65;
                }

                if (current)
                {
                    g.DrawImage(ImageCards(c), xCards, yCards, 70, 90);

                }
                else
                    g.DrawImage(Image.FromFile(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\CardsImage\\Down.png"), xCards, yCards, 70, 90);
                xCards += 65;

            }
        }

        /// <summary>
        /// Detect if the point is inside a player zonz
        /// </summary>
        /// <param name="point">The point</param>
        /// <returns></returns>
        public bool containsPlayerView(Point point)
        {
            Rectangle rect = new Rectangle(Coordinate, size);
            return rect.Contains(point);
        }

    }
}
