using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_HP : MonoBehaviour {
    public float fullHP { get; set; }
    public float HP { get; set; }
    private HP_Data HP_Data;
    // Use this for initialization
    void Start () {
        HP_Data = new HP_Data(fullHP);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.CompareTag("EnermyAttack"))
        //{
        //    HP_Data.decreaseHP(10);
        //}
    }
    void PlayerDeath()
    {
        if (HP < 0) {

        }
    }

}
