using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Lotation: MonoBehaviour {
    public Player_Move player;
    private SpriteRenderer transRender;
	// Use this for initialization
	void Start () {
        transRender = gameObject.GetComponentInChildren<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        MovePosition();
    }
    private void MovePosition()
    {
        if (player.getDirX() == 0)
        {
            transRender.flipX = true;
            gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(-10f, 0f);
        }
        else if (player.getDirX() == 1)
        {
            transRender.flipX = false;
            gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(10f, 0f);
        }
    }
}
