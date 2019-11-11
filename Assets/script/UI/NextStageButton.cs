using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextStageButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnMouseDown() { 
        System.Random rand = new System.Random();

        int r = rand.Next(0, 3); ;
        if (r == 0)
        {
            SceneManager.LoadScene("Stage1");
        }
        else if (r == 1)
        {
            SceneManager.LoadScene("Stage2");
        }
        else if (r == 2)
        {
            SceneManager.LoadScene("Stage3");
        }
    }
}
