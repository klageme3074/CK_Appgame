using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimControl : MonoBehaviour {

    public Player_Shot shot;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void KnifeAttack()
    {
        shot.Knife_Shot();
    }
    void HGShot()
    {
        shot.HG_Shot();
    }
    void ARShot()
    {
        shot.AR_Shot();
    }
}

