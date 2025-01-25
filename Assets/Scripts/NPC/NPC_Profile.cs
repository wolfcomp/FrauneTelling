using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NPC_Profile", menuName = "Scriptable Objects/NPC_Profile")]
public class NPC_Profile : ScriptableObject
{
    public string NPC_Name;
    public Sprite Sprite;
    public RelevantClueScript RelevantClue;
    public List<IrelevantClueScript> IrelevantClues;
    public string QuestionCategory;
}
