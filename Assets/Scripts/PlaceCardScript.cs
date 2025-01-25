using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlaceCardScript : MonoBehaviour
{
    [SerializeField] private InputSystem_Actions InputAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InputAction = new InputSystem_Actions();
        InputAction.Player.PlaceCard.performed += PlaceCard_performed;
        InputAction.Enable();
    }

    private void PlaceCard_performed(InputAction.CallbackContext obj)
    {
        Debug.Log("PlaceCard_performed");
        if (false) //check too see if the card is in the hand
        {
            return;
        }
        int layerMask = LayerMask.GetMask("CardHolderLayer");

        Ray Ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());

        if (!Physics.Raycast(Ray, out RaycastHit hit, 1000f, layerMask))
        {
            return;
        }
        GameObject CardHolder = hit.transform.gameObject;

        int children = CardHolder.GetComponentCount();
        Debug.Log(children);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
