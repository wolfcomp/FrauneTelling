using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private Canvas Bounds;

    Transform ParentToReturnTo = null;

    public void OnBeginDrag(PointerEventData eventData) 
    {
        Debug.Log("Card sure is starting to drag");

        //saves the parent of the card
        ParentToReturnTo = this.transform.parent;

        //sets the parent of the card to the canvas so it can be dragged freely
        this.transform.SetParent(this.transform.parent.parent);

        //disables the card from blocking raycasts while being dragged
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }


    public void OnDrag(PointerEventData eventData)
    {
        // transforms the position of the card to the position of the mouse, updated every frame
        this.transform.position = eventData.pointerCurrentRaycast.worldPosition; 

        
    }
    public void OnEndDrag(PointerEventData eventData) 
    {
        Debug.Log("Card sure stopped dragging");
        
        //sets the parent of the card to what it was originally
        this.transform.SetParent(ParentToReturnTo);

        //enables the card from blocking raycasts after it's dropped
        GetComponent<CanvasGroup>().blocksRaycasts = true;
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
