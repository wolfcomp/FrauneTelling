using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer has entered?");
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Pointer has exited?");
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Card sure has been dropped to " + gameObject.name);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
