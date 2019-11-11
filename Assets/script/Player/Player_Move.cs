using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public Set_Player_Data player_data;
    public JoyStick joystick;         //조이스틱 스크립트
    public float move_Speed = 3f;     //플레이어 이동속도
    
    private Vector2 move_vector;      //플레이어 이동벡터
    // Use this for initialization
    void Start()
    {
        move_vector = Vector2.zero;
    }

    // Update is called once per frame 매 프레임마다 움직이는 친구
    void Update()
    {
        HandleInput();
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void HandleInput()
    {
        move_vector = PoolIput();
    }

    public Vector2 PoolIput()
    {
        float h = joystick.GetHorizontalValue();
        Vector2 moveDir = new Vector2(h, 0).normalized;
        return moveDir;
    }

    public void Move()//이동을 맡은 함수
    {
         transform.Translate(move_vector * move_Speed * Time.deltaTime);

        if (joystick.GetHorizontalValue() < 0)//왼쪽을 보고 있을 때
        {
            player_data.Renderer.flipX = true;
            player_data.anim.SetBool("Player_Move", true);
        }
        else if (joystick.GetHorizontalValue() > 0)//오른쪽을 보고 있을 때
        {
            player_data.Renderer.flipX = false;
            player_data.anim.SetBool("Player_Move", true);
        }

        else { player_data.anim.SetBool("Player_Move", false); }
    }

    public int getDirX()
    {
        if (player_data.Renderer.flipX == true) { return 0; } //왼쪽을 보고있음
        else if (player_data.Renderer.flipX == false) { return 1; }//오른쪽을 보고있음 
        else return 0;

    }
}
