using UnityEngine;

[CreateAssetMenu(fileName = "Tarot Card Times", menuName = "Scriptable Objects/Tarot Card/Tarot Card Times Object")]
public class TarotCardTimesScriptableObject : ScriptableObject
{
    public TarotCardSentencesScriptableObject Past;
    public TarotCardSentencesScriptableObject Present;
    public TarotCardSentencesScriptableObject Future;
}