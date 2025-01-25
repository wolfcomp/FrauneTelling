using AYellowpaper.SerializedCollections;
using UnityEngine;

[CreateAssetMenu(fileName = "Tarot Card", menuName = "Scriptable Objects/Tarot Card/Tarot Card Object")]
public class TarotCardScriptableObject : ScriptableObject
{
    public string Name;
    public Sprite Sprite;
    public SerializedDictionary<string, TarotCardTimes> Sentences = new();
}

[CreateAssetMenu(fileName = "Tarot Card Times", menuName = "Scriptable Objects/Tarot Card/Tarot Card Times Object")]
public class TarotCardTimes : ScriptableObject
{
    public TarotCardSentences Past;
    public TarotCardSentences Present;
    public TarotCardSentences Future;
}

[CreateAssetMenu(fileName = "Tarot Card Sentences", menuName = "Scriptable Objects/Tarot Card/Tarot Card Sentences Object")]
public class TarotCardSentences : ScriptableObject
{
    public string Good;
    public string Bad;
}