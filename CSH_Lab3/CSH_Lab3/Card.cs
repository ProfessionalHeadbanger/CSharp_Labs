using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Card
{
    public string Rank { get; private set; }
    public string Suit { get; private set; }

    public static readonly string[] RankSymbols = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
    public static readonly string[] SuitSymbols = { "♠️", "♦️", "♥️", "♣️" };

    private static readonly Dictionary<string, string> RankAliases = new Dictionary<string, string>
{
    {"two", "2"},
    {"three", "3"},
    {"four", "4"},
    {"five", "5"},
    {"six", "6"},
    {"seven", "7"},
    {"eight", "8"},
    {"nine", "9"},
    {"ten", "10"},
    {"jack", "J"},
    {"queen", "Q"},
    {"king", "K"},
    {"ace", "A"},
    {"двойка", "2"},
    {"тройка", "3"},
    {"четверка", "4"},
    {"пятерка", "5"},
    {"шестерка", "6"},
    {"семерка", "7"},
    {"восьмерка", "8"},
    {"девятка", "9"},
    {"десятка", "10"},
    {"валет", "J"},
    {"королева", "Q"},
    {"король", "K"},
    {"туз", "A"}
};

    private static readonly Dictionary<string, string> SuitAliases = new Dictionary<string, string>
{
    {"spades", "♠️"},
    {"diamonds", "♦️"},
    {"hearts", "♥️"},
    {"clubs", "♣️"},
    {"пики", "♠️"},
    {"бубны", "♦️"},
    {"червы", "♥️"},
    {"трефы", "♣️"}
};

    public Card(string rank, string suit)
    {
        Rank = rank;
        Suit = suit;
    }

    public override string ToString()
    {
        return $"{Rank}{Suit}";
    }

    public static IEnumerable<Card> GenerateAllCards()
    {
        var allCards = from suit in SuitSymbols
                       from rank in RankSymbols
                       select new Card(rank, suit);

        return allCards;
    }

    public static IEnumerable<Card> GenerateRandomDeck()
    {
        var random = new Random();
        int numberOfCards = random.Next(10, 21);

        var randomDeck = new List<Card>();

        for (int i = 0; i < numberOfCards; i++)
        {
            string rank = RankSymbols[random.Next(RankSymbols.Length)];
            string suit = SuitSymbols[random.Next(SuitSymbols.Length)];
            randomDeck.Add(new Card(rank, suit));
        }

        return randomDeck;
    }

    public static bool TryParse(string input, out Card card)
    {
        card = null;

        if (string.IsNullOrEmpty(input))
        {
            return false;
        }

        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length != 2)
        {
            return false;
        }

        string rankAlias = words[0].ToLower();
        string suitAlias = words[1].ToLower();

        if (RankAliases.TryGetValue(rankAlias, out string rankSymbol))
        {
            rankAlias = rankSymbol;
        }

        if (SuitAliases.TryGetValue(suitAlias, out string suitSymbol))
        {
            suitAlias = suitSymbol;
        }

        if (!RankSymbols.Contains(rankAlias) || !SuitSymbols.Contains(suitAlias))
        {
            return false;
        }

        card = new Card(rankAlias, suitAlias);
        return true;
    }

    public static bool IsSeries(IEnumerable<Card> cards)
    {
        if (cards.Count() == 0)
        {
            return false;
        }

        bool isSeries = cards
        .Select(card => new { RankValue = GetRankValue(card.Rank), Suit = card.Suit })
        .Zip(cards.Skip(1).Select(card => new { RankValue = GetRankValue(card.Rank), Suit = card.Suit }), (prev, next) => (prev, next))
        .All(pair =>
        {
            int rankDifference = pair.next.RankValue - pair.prev.RankValue;
            bool isDifferentColor = IsDifferentColor(pair.prev.Suit, pair.next.Suit);

            return rankDifference == 1 && isDifferentColor;
        });

        return isSeries;
    }

    public static int GetRankValue(string rank)
    {
        string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        return Array.IndexOf(ranks, rank);
    }

    public static string GetRankName(int rankValue)
    {
        string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        return ranks[rankValue];
    }
    public static bool IsDifferentColor(string suit1, string suit2)
    {
        return (suit1 == "♠️" || suit1 == "♣️") != (suit2 == "♠️" || suit2 == "♣️");
    }
    public static IEnumerable<Card> MergeSeries(IEnumerable<Card> series1, IEnumerable<Card> series2)
    {
        if (IsSeries(series1) && IsSeries(series2))
        {
            var mergedSeries = series1.Concat(series2);
            if (IsSeries(mergedSeries))
            {
                return mergedSeries;
            }
        }
        return Enumerable.Empty<Card>();
    }
}

public static class CardExtentions
{
    public static IEnumerable<Card> Shuffle(this IEnumerable<Card> cards)
    {
        var random = new Random();
        return cards.OrderBy(card => random.Next());
    }
}
