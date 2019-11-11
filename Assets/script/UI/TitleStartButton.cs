using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleStartButton : MonoBehaviour {
    // Use this for initialization
    public FadeIn fadeIn;

    private void Update()
    {
        if (!fadeIn.isPlaying&&fadeIn.time>1f)
        {
            SceneManager.LoadScene("Stage");
        }
    }
    private void OnMouseUpAsButton()
    {
        fadeIn.isPlaying = true;
    }
}
