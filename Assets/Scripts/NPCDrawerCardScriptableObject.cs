using UnityEngine;

[CreateAssetMenu(fileName = "NPC Drawer Card", menuName = "Scriptable Objects/NPC Drawer Card")]
public class NPCDrawerCardScriptableObject : ScriptableObject
{
    public string Name;
    public string Occupation;
    public string Detailed;
    public Sprite Sprite;
}
