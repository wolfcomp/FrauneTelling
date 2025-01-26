using AYellowpaper.SerializedCollections;
using UnityEngine;

[CreateAssetMenu(fileName = "JuicyDetailScript", menuName = "Scriptable Objects/JuicyDetailScript")]
public class JuicyDetailScript : ScriptableObject
{
    public string Category; //Past, Present, or Future
    public string DescriptionText;
    public SerializedDictionary<TarotCardScriptableObject, int> TarotCardCorrectness; //-2 for correct card wrong default rotation.-1 for wrong card irelevant default rotation. -1 wrong vard relevant default rotation. 2 for correct card correct default rotation.

}
