using UnityEngine;
using UnityEngine.UI;

public class SpriteAnim : MonoBehaviour
{
    private Image spriteImage;

    [SerializeField] private Sprite[] _sprites;

    [SerializeField]
    private float FramesPerSecond = 1f;

    private float _timer = 0f;
    
    private int _index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer >= 1f / FramesPerSecond)
        {
            _timer = 0f;
            if (_index >= _sprites.Length)
            {
                _index = 0;
            }
            spriteImage.sprite = _sprites[_index++];
        }
        else
        {
            _timer += Time.deltaTime;
        }
    }
}
