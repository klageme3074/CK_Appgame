using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour {

    public Animator animator { get; set; }
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void EndAnime()
    {
        Destroy(gameObject);
    }
}
