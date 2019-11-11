using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public Sprite sprite;
	// Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>().sprite = sprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
