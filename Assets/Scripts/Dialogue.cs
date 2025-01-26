using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    [SerializeField]
    private Image grandmaImage;

    [SerializeField]
    private Vector3 grandmaMainPosition;

    [SerializeField]
    private int grandmaDialougeIndex = -1;

    [SerializeField]
    private NPCDialogue grandmaDialogue;

    [SerializeField]
    private float moveGrandmaDelta;

    [SerializeField]
    private sbyte moveGrandma;

    //The stupid things I've been doing - Kittel-Watne
    [SerializeField]
    private Image customerImage;

    [SerializeField]
    private Vector3 customerMainPosition;

    [SerializeField]
    private int customerDialougeIndex = -1;

    [SerializeField]
    private NPCDialogue customerDialogue;

    [SerializeField]
    private float moveCustomerDelta;

    [SerializeField]
    private sbyte moveCustomer;
    // End stupid things I've been doing - Kittel-Watne

    [SerializeField]
    private TextMeshProUGUI speachBuble;

    [SerializeField]
    private Image speachBubleImage;

    [SerializeField]
    private float easeInTime = 0.5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speachBubleImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Grandma Movement
        if (Input.GetKeyDown(KeyCode.G))
        {
            updateMove(ref moveGrandma, ref moveGrandmaDelta, grandmaMainPosition, grandmaImage);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            updateText(ref grandmaDialougeIndex, grandmaDialogue);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            updateMove(ref moveCustomer, ref moveCustomerDelta, customerMainPosition, customerImage);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            updateText(ref customerDialougeIndex, customerDialogue);
        }

        move(ref moveGrandma, ref moveGrandmaDelta, grandmaMainPosition, grandmaImage);
        move(ref moveCustomer, ref moveCustomerDelta, customerMainPosition, customerImage);

        void updateMove(ref sbyte move, ref float moveDelta, Vector3 mainPosition, Image image)
        {
            move++;
            if (move == 2)
            {
                move = -1;
            }
        }

        void move(ref sbyte move, ref float moveDelta, Vector3 mainPosition, Image image)
        {
            if (move == 1)
            {
                moveDelta += Time.deltaTime;
            }
            else if (move == -1)
            {
                moveDelta -= Time.deltaTime;
            }
            moveDelta = Mathf.Clamp(moveDelta, 0, easeInTime);
            image.transform.localPosition = Vector3.Lerp(new(0,-6000,0), mainPosition, moveDelta / easeInTime);

            if (move == -1 && moveDelta <= 0)
            {
                move = 0;
            }
        }

        void updateText(ref int dialougeIndex, NPCDialogue npcDialogue)
        {
            dialougeIndex++;
            if (dialougeIndex >= npcDialogue.Dialogue.Count)
            {
                speachBuble.text = "";
                dialougeIndex = -1;
                speachBubleImage.enabled = false;
            }
            else
            {
                speachBuble.text = npcDialogue.Dialogue[dialougeIndex];
                speachBubleImage.enabled = true;
            }
        }
    }
}
