using UnityEngine;
using System.Collections.Generic;


public class PseudoGif : MonoBehaviour
{
    [SerializeField] List<Sprite> frames;
    [SerializeField] float frameDuration = 0.25f;
    float elapsed = 0;

    SpriteRenderer renderer;
    int currentFrame = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
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
