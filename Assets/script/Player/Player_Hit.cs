using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Hit : MonoBehaviour {

    public Set_Player_Data player_Data;
    private void Update()
    {
        if (!player_Data.anim.GetCurrentAnimatorStateInfo(0).IsName("Player_Knife_Hit") ||
              !player_Data.anim.GetCurrentAnimatorStateInfo(0).IsName("Player_AR_Hit") ||
              !player_Data.anim.GetCurrentAnimatorStateInfo(0).IsName("Player_HG_Hit"))
        {
            player_Data.anim.SetBool("Player_Hit", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Damage"))
        {
            Debug.Log("tq");
            player_Data.anim.SetBool("Player_Hit", true);
        }
    }
}
