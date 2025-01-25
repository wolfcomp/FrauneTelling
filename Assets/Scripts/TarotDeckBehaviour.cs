using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TarotDeckBehaviour : MonoBehaviour
{
    [SerializeField]
    private List<TarotCardScriptableObject> cards = new();

    [SerializeField]
    private List<int> shuffledCards;

    private float timer = 0;

    void Start()
    {
        var rng = new System.Random();
        shuffledCards = cards.OrderBy(x => rng.Next()).Select(x => cards.IndexOf(x)).ToList();
    }

    public TarotCardScriptableObject GetNextCard()
    {
        var next = shuffledCards[0];
        shuffledCards.RemoveAt(0);
        shuffledCards.Add(next);
        return cards[next];
    }
}
