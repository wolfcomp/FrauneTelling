using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private Canvas Bounds;

    public void OnBeginDrag(PointerEventData eventData) 
    {
        Debug.Log("Card sure is starting to drag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Card sure is dragging");
        this.transform.position = eventData.pointerCurrentRaycast.worldPosition;
    }
    public void OnEndDrag(PointerEventData eventData) 
    {
        Debug.Log("Card sure stopped dragging");
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
