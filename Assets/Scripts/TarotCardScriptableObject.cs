using AYellowpaper.SerializedCollections;
using UnityEngine;

[CreateAssetMenu(fileName = "Tarot Card", menuName = "Scriptable Objects/Tarot Card/Tarot Card Object")]
public class TarotCardScriptableObject : ScriptableObject
{
    public string Name;
    public Sprite Sprite;
    public SerializedDictionary<string, TarotCardTimesScriptableObject> Sentences = new();
}