using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PokerProject
{
    public partial class Discard : Form
    {
        List<Card> cards;
        List<Card> selectionCards;

        /// <summary>
        /// Constructor of the Discard form
        /// </summary>
        /// <param name="cards"></param>
        public Discard(List<Card> cards)
        {
            InitializeComponent();
            this.cards = cards;
            this.cards.ForEach(c => listBoxCard.Items.Add(c));
            this.selectionCards = new List<Card>();
        }

        /// <summary>
        /// Discard cards selected
        /// </summary>
        /// <param name="sender">The object</param>
        /// <param name="e">The event</param>
        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            if (listBoxCard.SelectedIndex != -1)
            {
                for (int i = 0; i < listBoxCard.SelectedIndices.Count; i++)
                {
                    Card card = (Card)listBoxCard.Items[listBoxCard.SelectedIndices[i]];
                    selectionCards.Add(card);
                    listBoxCard.Items.Remove(card);
                    int indexNumber = card.ToString().IndexOf('(');
                    int indexType = card.ToString().LastIndexOf('(');
                    String result = card.ToString()[indexNumber + 1] + "" + card.ToString()[indexType + 1];
                    GameControler.Interpret("discard " + result);
                }
                GameControler.Interpret("next");
                this.Close();

            }
        }
    }
}
