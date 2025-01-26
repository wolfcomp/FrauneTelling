using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NPCDialogue", menuName = "Scriptable Objects/NPCDialogue")]
public class NPCDialogue : ScriptableObject
{
    public List<string> Dialogue;
    public Vector3 Position;
    public Sprite Sprite;
}
