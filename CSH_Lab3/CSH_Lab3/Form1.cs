using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSH_Lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void task1Button_Click(object sender, EventArgs e)
        {
            example1Button.Visible = false;
            example2Button.Visible = false;
            example3Button.Visible = false;
            inputCardTextBox.Visible = false;
            inputCardButton.Visible = false;
            shuffleButton.Visible = true;
            richTextBoxOutput.Clear();
            var allCards = Card.GenerateAllCards();
            richTextBoxOutput.Text = string.Join(", ", allCards);
            shuffleButton.Tag = allCards;
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            if (shuffleButton.Tag is IEnumerable<Card> allCards)
            {
                var shuffledCards = allCards.Shuffle();
                richTextBoxOutput.Clear();
                richTextBoxOutput.Text = string.Join(", ", shuffledCards);
            }
        }

        private void task2Button_Click(object sender, EventArgs e)
        {
            example1Button.Visible = false;
            example2Button.Visible = false;
            example3Button.Visible = false;
            shuffleButton.Visible = false;
            inputCardTextBox.Visible = true;
            inputCardButton.Visible = true;
            richTextBoxOutput.Clear();
        }

        private void inputCardButton_Click(object sender, EventArgs e)
        {
            if (Card.TryParse(inputCardTextBox.Text, out Card card))
            {
                richTextBoxOutput.Text += "Принято: " + card.ToString() + "\n";
            }
            else
            {
                richTextBoxOutput.Text += "Не распознано: " + inputCardTextBox.Text + "\n";
            }
        }

        private void task3Button_Click(object sender, EventArgs e)
        {
            shuffleButton.Visible = false;
            inputCardTextBox.Visible = false;
            inputCardButton.Visible = false;
            richTextBoxOutput.Clear();
            example1Button.Visible = false;
            example2Button.Visible = false;
            example3Button.Visible = false;

            var randomDeck = Card.GenerateRandomDeck();

            var diamonds = randomDeck
                .Where(card => card.Suit == "♦️")
                .OrderBy(card =>
                    card.Rank == "A" ? 1 : Array.IndexOf(Card.RankSymbols, card.Rank) + 2);

            var spades = randomDeck
                .Where(card => card.Suit == "♠️")
                .OrderBy(card =>
                    card.Rank == "A" ? 14 : Array.IndexOf(Card.RankSymbols, card.Rank) + 2);

            var sortedDeck = diamonds.Concat(spades).ToList();

            richTextBoxOutput.Text = "Изначальная случайная колода: \n" + string.Join(", ", randomDeck) + "\n" + 
                "Отсортированная колода: \n" + string.Join(", ", sortedDeck);
        }

        private void task4Button_Click(object sender, EventArgs e)
        {
            shuffleButton.Visible = false;
            inputCardTextBox.Visible = false;
            inputCardButton.Visible = false;
            richTextBoxOutput.Clear();
            example1Button.Visible = true;
            example2Button.Visible = true;
            example3Button.Visible = true;
        }

        private void example1Button_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Clear();

            var deck1 = new List<Card> { new Card("A", "♥️"), new Card("2", "♠️"), new Card("3", "♦️"), new Card("4", "♠️"), new Card("5", "♥️") };
            var deck2 = new List<Card> { new Card("6", "♠️"), new Card("7", "♦️"), new Card("8", "♠️"), new Card("9", "♥️") }; 

            var merged = Card.MergeSeries(deck1, deck2);

            richTextBoxOutput.Text += "Первая последовательность: " + string.Join(", ", deck1) + "\n";
            richTextBoxOutput.Text += "Вторая последовательность: " + string.Join(", ", deck2) + "\n";
            richTextBoxOutput.Text += "Результирующая серия: " + string.Join(", ", merged) + "\n";
        }

        private void example2Button_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Clear();
            var deck1 = new List<Card> { new Card("A", "♥️"), new Card("2", "♠️"), new Card("3", "♦️"), new Card("4", "♠️"), new Card("5", "♥️") };
            var deck2 = new List<Card> { new Card("7", "♠️"), new Card("8", "♦️"), new Card("9", "♠️"), new Card("10", "♥️") };

            var merged = Card.MergeSeries(deck1, deck2);

            richTextBoxOutput.Text += "Первая последовательность: " + string.Join(", ", deck1) + "\n";
            richTextBoxOutput.Text += "Вторая последовательность: " + string.Join(", ", deck2) + "\n";
            richTextBoxOutput.Text += "Результирующая серия: " + string.Join(", ", merged) + "\n";
        }

        private void example3Button_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Clear();
            var deck1 = new List<Card> { new Card("A", "♥️"), new Card("2", "♠️"), new Card("3", "♦️"), new Card("4", "♠️"), new Card("5", "♥️") };
            var deck2 = new List<Card> { new Card("6", "♥️"), new Card("7", "♣️"), new Card("8", "♦️"), new Card("9", "♠️") };

            var merged = Card.MergeSeries(deck1, deck2);

            richTextBoxOutput.Text += "Первая последовательность: " + string.Join(", ", deck1) + "\n";
            richTextBoxOutput.Text += "Вторая последовательность: " + string.Join(", ", deck2) + "\n";
            richTextBoxOutput.Text += "Результирующая серия: " + string.Join(", ", merged) + "\n";
        }

        private void hardtask5Button_Click(object sender, EventArgs e)
        {
            shuffleButton.Visible = false;
            inputCardButton.Visible = false;
            inputCardTextBox.Visible = false;
            example1Button.Visible = false;
            example2Button.Visible = false;
            example3Button.Visible = false;
            richTextBoxOutput.Clear();

            var randomDeck = Card.GenerateRandomDeck();

            richTextBoxOutput.Text = "Изначальная случайная колода: " + string.Join(", ", randomDeck) + "\n";

            var minMaxRanksBySuit = randomDeck
                .GroupBy(card => card.Suit)
                .ToDictionary(group => group.Key, group =>
                (
                    MinRank: group.Min(card => Card.GetRankValue(card.Rank)),
                    MaxRank: group.Max(card => Card.GetRankValue(card.Rank))
                )
            );

            foreach (var suit in minMaxRanksBySuit.Keys)
            {
                var (minRank, maxRank) = minMaxRanksBySuit[suit];
                richTextBoxOutput.Text += "Масть: " + suit + ", Минимальный ранг: " + Card.GetRankName(minRank) + ", Максимальный ранг: " + Card.GetRankName(maxRank) + "\n";
            }
        }
    }
}
