using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    public float fadeTime = 2f;
    public bool isPlaying { get; set; }
    public float time { get; set; }

    private SpriteRenderer fadesprite;
    private Color fadecolor;
    // Use this for initialization
    void Awake()
    {
        fadesprite = GetComponent<SpriteRenderer>();
        fadecolor = fadesprite.color;
        isPlaying = false;
        time = 0f;
    }

    // Update is called once per frame
    private void Update()
    {
        PlayFadeIn();
    }

    private void PlayFadeIn()
    {
        if (fadecolor.a < 1f && isPlaying)
        {
            time += Time.deltaTime / fadeTime;
            fadecolor.a = time;
            GetComponent<SpriteRenderer>().color = fadecolor;
        }
        else if (time > 1f)
        {
            isPlaying = false;
        }
    }
}
