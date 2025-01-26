using Unity.VisualScripting;
using UnityEngine;

public class AnimationTester : MonoBehaviour
{
    [SerializeField]
    private Animation animation;

    [SerializeField] 
    private bool HasSeenDrawer;

    [SerializeField]
    private bool HasSeenGrandma;

    [SerializeField]
    private bool HasSeenGosip;

    [SerializeField]
    private bool HasPlayedCards;

    [SerializeField]
    private bool HasSeenReading;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (AnimationState _animationState in animation)
        {
            Debug.Log(_animationState.name);
        }

        // Force camera to be in the correct location for start
        animation["Card Play To Drawer"].time = 0;
        animation["Card Play To Drawer"].speed = -1;
        animation.Play("Card Play To Drawer");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!HasSeenDrawer)
            {
                animation["Card Play To Drawer"].time = 0;
                animation["Card Play To Drawer"].speed = 1;
                animation.Play("Card Play To Drawer");
                HasSeenDrawer = true;
                return;
            }

            if (!HasSeenGrandma)
            {
                animation["Drawer To Ghost"].time = 0;
                animation["Drawer To Ghost"].speed = 1;
                animation.Play("Drawer To Ghost");
                HasSeenGrandma = true;
                return;
            }

            if (!HasSeenGosip)
            {
                animation["Drawer To Ghost"].time = animation["Drawer To Ghost"].length;
                animation["Drawer To Ghost"].speed = -1;
                animation.Play("Drawer To Ghost");
                HasSeenGosip = true;
                return;
            }

            if (!HasPlayedCards)
            {
                animation["Card Play To Drawer"].time = animation["Card Play To Drawer"].length;
                animation["Card Play To Drawer"].speed = -1;
                animation.Play("Card Play To Drawer");
                HasPlayedCards = true;
                return;
            }

            if (!HasSeenReading)
            {
                animation["Card Play To Reading"].time = 0;
                animation["Card Play To Reading"].speed = 1;
                animation.Play("Card Play To Reading");
                HasSeenReading = true;
                return;
            }

            animation["Card Play To Reading"].time = animation["Card Play To Reading"].length;
            animation["Card Play To Reading"].speed = -1;
            animation.Play("Card Play To Reading");
            HasSeenDrawer = false;
            HasSeenGrandma = false;
            HasPlayedCards = false;
            HasSeenReading = false;
            HasSeenGosip = false;
        }
    }
}
