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
    private TextMeshProUGUI speachBuble;

    [SerializeField]
    private Image speachBubleImage;

    [SerializeField]
    private float easeInTime = 0.5f;

    [SerializeField]
    private float moveDelta;

    [SerializeField]
    private sbyte moveGrandma;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speachBubleImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            moveGrandma++;
            if (moveGrandma == 2)
            {
                moveGrandma = -1;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            grandmaDialougeIndex++;
            if (grandmaDialougeIndex >= grandmaDialogue.Dialogue.Count)
            {
                speachBuble.text = "";
                grandmaDialougeIndex = -1;
                speachBubleImage.enabled = false;
            }
            else
            {
                speachBuble.text = grandmaDialogue.Dialogue[grandmaDialougeIndex];
                speachBubleImage.enabled = true;
            }
        }

        else if (moveGrandma == 1)
        {
            moveDelta += Time.deltaTime;
        }
        else if (moveGrandma == -1)
        {
            moveDelta -= Time.deltaTime;
        }
        moveDelta = Mathf.Clamp(moveDelta, 0, easeInTime);
        grandmaImage.transform.localPosition = Vector3.Lerp(new(0,-grandmaImage.preferredHeight,0), grandmaMainPosition, moveDelta / easeInTime);

        if (moveGrandma == -1 && moveDelta <= 0)
        {
            moveGrandma = 0;
        }
    }
}
