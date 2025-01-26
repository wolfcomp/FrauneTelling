using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("Pointer has entered?");
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("Pointer has exited?");
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name + " has been dropped to " + gameObject.name);

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            if (gameObject.transform.childCount == 0)
            {
                d.ParentToReturnTo = this.transform;
            }
            else
            {
                var childDraggable = gameObject.GetComponentInChildren<Draggable>();
                if (childDraggable != null)
                {
                    childDraggable.transform.SetParent(d.ParentToReturnTo);
                    d.ParentToReturnTo = this.transform;
                }
            }
        }
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
