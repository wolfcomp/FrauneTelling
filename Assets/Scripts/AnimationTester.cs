using UnityEngine;

public class AnimationTester : MonoBehaviour
{
    [SerializeField]
    private Animation animation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (AnimationState _o in animation)
        {
            Debug.Log(_o.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !animation.isPlaying)
        {
            if (Input.GetKey(KeyCode.LeftControl))
            {
                animation["Card Play To Drawer"].time = animation["Card Play To Drawer"].length;
                animation["Card Play To Drawer"].speed = -1;
                animation.Play("Card Play To Drawer");
            }
            else
            {
                animation["Card Play To Drawer"].time = 0;
                animation["Card Play To Drawer"].speed = 1;
                animation.Play("Card Play To Drawer");
            }
        }
        if (Input.GetKeyUp(KeyCode.V))
        {
            if (Input.GetKey(KeyCode.LeftControl))
            {
                animation["Card Play To Reading"].time = animation["Card Play To Reading"].length;
                animation["Card Play To Reading"].speed = -1;
                animation.Play("Card Play To Reading");
            }
            else
            {
                animation["Card Play To Reading"].time = 0;
                animation["Card Play To Reading"].speed = 1;
                animation.Play("Card Play To Reading");
            }
        }
    }
}
