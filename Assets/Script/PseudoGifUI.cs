using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;


public class PseudoGifUI : MonoBehaviour
{
    [SerializeField] List<Sprite> frames;
    [SerializeField] float frameDuration = 0.25f;
    float elapsed = 0;

    Image renderer;
    int currentFrame = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;

        if (elapsed >= frameDuration)
        {
            elapsed = 0;
            currentFrame = (currentFrame + 1) % frames.Count;
            renderer.sprite = frames[currentFrame];
        }
    }
}
