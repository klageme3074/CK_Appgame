using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Player_Data : MonoBehaviour {

    public SpriteRenderer Renderer { get; set; }
    public Vector3 pos { get;  set; }
    public Animator anim { get; set; }

    // Use this for initialization
    void Start () {
        pos = transform.position;
        anim = GetComponent<Animator>();
        Renderer = gameObject.GetComponentInChildren<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
}
