using UnityEngine;

[CreateAssetMenu(fileName = "JuicyDetailCategoryContainerScript", menuName = "Scriptable Objects/JuicyDetailCategoryContainerScript")]
public class JuicyDetailCategoryContainerScript : ScriptableObject
{
    public string Category;
    public JuicyDetailScript JuicyDetailPast;
    public JuicyDetailScript JuicyDetailPresent;
    public JuicyDetailScript JuicyDetailFuture;
}
