using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using System;
public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private Canvas Bounds;

    public Transform ParentToReturnTo = null;

    [SerializeField] private Vector3 PickedUpScale = new(1.2f,1.2f,1f);

    private bool ShouldScale;

    private float ScaleDelta;

    [SerializeField] private float ScaleTimeFrame;

    [System.Obsolete]
    public void OnBeginDrag(PointerEventData eventData) 
    {
        Debug.Log("Card sure is starting to drag");

        ShouldScale = true;

        //saves the parent of the card
        ParentToReturnTo = this.transform.parent;

        //sets the parent of the card to the canvas so it can be dragged freely
        var transformParent = transform.parent;
        while (transformParent.name != "Panel")
        {
            transformParent = transformParent.parent;
        }

        this.transform.SetParent(transformParent);

        //disables the card from blocking raycasts while being dragged
        GetComponent<CanvasGroup>().blocksRaycasts = false;

        //this can be used to select all available slots to make them glow or highlight or something
        //DropZone[] zones = GameObject.FindObjectsOfType<DropZone>();

      
    }


    public void OnDrag(PointerEventData eventData)
    {
        // transforms the position of the card to the position of the mouse, updated every frame
        this.transform.position = eventData.pointerCurrentRaycast.worldPosition; 

        
    }
    public void OnEndDrag(PointerEventData eventData) 
    {
        Debug.Log("Card sure stopped dragging");

        ShouldScale = false;

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
        if (ShouldScale)
        {
            ScaleDelta += Time.deltaTime;
            ScaleDelta = MathF.Min(ScaleDelta, ScaleTimeFrame);
        }
        else
        {
            ScaleDelta -= Time.deltaTime;
            ScaleDelta = Mathf.Max(ScaleDelta, 0f);
        }
        this.transform.localScale = Vector3.Lerp(Vector3.one, PickedUpScale, ScaleDelta);
    }
}
