using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//나중에 리로드랑 나눠라
public class Player_Shot : MonoBehaviour
{
    public Text bulletText;
    public Effect arEffect;             //ar이펙트
    public Effect hgEffect;             //handGun이펙트
    public Set_Player_Data player_Data; 
    public Button_on_Click shotButton;
    public Button_on_Click reloadButton;
    public GameObject L_bulletObject;    // 미사일 오브젝트
    public GameObject R_bulletObject;    // 미사일 오브젝트
    public SwapButton swapButton;
    public int arBulletCount;
    public int hgBulletCount;
    public float shotDelay;             // 미사일 발사 속도(미사일이 날라가는 속도x)
    
    private int arBulletCountMax;
    private int hgBulletCountMax;
    private int bullet_Count;
    private bool shotState;             // 총알이 나갈 수 있는 상황인지 판단하는 함수
    private Player_Move move;
    private Vector3 bulletLocation;     // 미사일이 발사될 위치
    private int wephoneType;            // 나중에 enum으로 바꿔라
    private Vector3 effectVec;
    

    void Start()
    {
        // 처음에 미사일을 발사할 수 있도록 제어변수를 true로 설정
        shotState = true;

        arBulletCountMax = 30;
        hgBulletCountMax = 10;
        bullet_Count = 1;
        move = GetComponent<Player_Move>();
        InitBulletPositoin();
        arEffect.GetComponent<SpriteRenderer>().enabled = false;


    }

    void Update()
    {
        // 매 프레임마다 미사일발사 함수를 체크한다.
        PlayerFire();
        DrawBulletCount();
    }

    // 미사일을 발사하는 함수
    private void PlayerFire()
    {
        wephoneType = swapButton.wephoneType;
        if (reloadButton.gettouch()) {//고치는 중
            switch (wephoneType)
            {
                case 0:
                    bullet_Count = 1;
                    break;
                case 1:
                    bullet_Count = hgBulletCountMax;
                    break;
                case 2:
                    bullet_Count = arBulletCountMax;
                    break;
            }
        }
        
        if (!shotButton.gettouch())
        {
            arEffect.GetComponent<SpriteRenderer>().enabled = false;
            player_Data.anim.SetBool("Player_Attack", false);
        }
        if (shotButton.gettouch() && shotState && bullet_Count > 0)
        {
            if(wephoneType==2)
                arEffect.GetComponent<SpriteRenderer>().enabled = true;
            Bullet_Create();
        }
        
    }


    // 코루틴 함수
    IEnumerator FireCycleControl()
    {
        // 처음에 FireState를 false로 만들고
        shotState = false;
        // FireDelay초 후에
        yield return new WaitForSeconds(shotDelay);
        // FireState를 true로 만든다.
        shotState = true;
    }
    

    private void DrawBulletCount()
    {
        bulletText.text = bullet_Count.ToString();
    }

    private void Bullet_Create()
    {
        StartCoroutine(FireCycleControl());

        InitBulletPositoin();
        if (move.getDirX() == 1)//왼쪽을 보고있음
        {
            player_Data.anim.SetBool("Player_Attack", true);
        }
        else if (move.getDirX() == 0)//오른쪽을 보고있음
        {
            player_Data.anim.SetBool("Player_Attack", true);
        }
    }

    private void InitBulletPositoin()
    {
        bulletLocation.x = player_Data.transform.position.x;
        bulletLocation.y = player_Data.transform.position.y + 0.7f;
        bulletLocation.z = player_Data.transform.position.z;
    }



    void HitAnimeEnd()
    {
        player_Data.anim.SetBool("Player_Attack", true);
    }

    public void Knife_Shot()
    {
        bullet_Count = 1;
        if (move.getDirX() == 1)
        {
            Instantiate(L_bulletObject, bulletLocation, Quaternion.identity);
            L_bulletObject.GetComponent<Bullet>().Bullet_Life = 0.1f;
        }
        else if (move.getDirX() == 0)
        {
            Instantiate(R_bulletObject, bulletLocation, Quaternion.identity);
            R_bulletObject.GetComponent<Bullet>().Bullet_Life = 0.1f;
        }
    }

    public void HG_Shot()
    {
        if (bullet_Count > 0)
        {
            if (move.getDirX() == 1)
            {
                Instantiate(L_bulletObject, bulletLocation, Quaternion.identity);

                L_bulletObject.GetComponent<Bullet>().Bullet_Life = 1.0f;

                effectVec = bulletLocation;
                effectVec += new Vector3(1.7f, -0.40f, 0f);
                Instantiate(hgEffect.gameObject, effectVec, Quaternion.identity);
                bullet_Count--;
                hgEffect.GetComponent<SpriteRenderer>().flipX = false;

            }
            else if (move.getDirX() == 0)
            {
                Instantiate(R_bulletObject, bulletLocation, Quaternion.identity);

                R_bulletObject.GetComponent<Bullet>().Bullet_Life = 1.0f;

                effectVec = bulletLocation;
                effectVec += new Vector3(-1.7f, -0.40f, 0f);
                Instantiate(hgEffect.gameObject, effectVec, Quaternion.identity);
                bullet_Count--;
                hgEffect.GetComponent<SpriteRenderer>().flipX = true;
            }
        }
        else
        {
            player_Data.anim.SetBool("Player_Attack", false);
        }
    }

    public void AR_Shot()
    {
        if (bullet_Count > 0)
        {
            if (move.getDirX() == 1)
            {
                Instantiate(L_bulletObject, bulletLocation, Quaternion.identity);

                L_bulletObject.GetComponent<Bullet>().Bullet_Life = 1.0f;

                arEffect.transform.position = bulletLocation;
                arEffect.transform.position += new Vector3(1.7f, -0.55f, 0f);
                arEffect.GetComponent<SpriteRenderer>().flipX = false;
                bullet_Count--;

            }

            else if (move.getDirX() == 0)
            {
                Instantiate(R_bulletObject, bulletLocation, Quaternion.identity);

                R_bulletObject.GetComponent<Bullet>().Bullet_Life = 1.0f;

                arEffect.transform.position = bulletLocation;
                arEffect.transform.position += new Vector3(-1.7f, -0.55f, 0f);
                arEffect.GetComponent<SpriteRenderer>().flipX = true;
                bullet_Count--;
            }
        }
        else
        {
            player_Data.anim.SetBool("Player_Attack", false);
        }
    }
}
