using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector2 move_Vector;
    private HP_Data enemyHP;
    private Transform move_transform;
    private Animator anim;
    private Vector3 damageLocation;

    public GameObject damageCreate;
    public float HP;
    public float move_speed;
    public float Range = 5.0f;
    public float attackDelay=1f;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        move_transform = transform;
        move_Vector = Vector2.zero;
        enemyHP = new HP_Data(HP);//체력을 생성 초기화
    }
    private void Update()
    {
        Move();
        Death();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))//만약 
        {
            enemyHP.decreaseHP(10);
            Debug.Log(gameObject.name + "의 현재 체력" + enemyHP.getHp());
        }
    }
    private void Move()//다음부턴 걍 콜라이더 쓰자
    {
        Debug.DrawRay(transform.position, Vector2.right * Range, Color.blue);//오른쪽 레이져
        Debug.DrawRay(transform.position, Vector2.left * Range, Color.red);//왼쪽 레이져

        RaycastHit2D[] hit1;
        RaycastHit2D[] hit2;
        hit1 = Physics2D.RaycastAll(transform.position, Vector2.left, Range);
        hit2 = Physics2D.RaycastAll(transform.position, Vector2.right, Range);

        RaycastHit2D[] hit3;
        RaycastHit2D[] hit4;
        hit3 = Physics2D.RaycastAll(transform.position, Vector2.left, 1f);
        hit4 = Physics2D.RaycastAll(transform.position, Vector2.right, 1f);

        foreach (RaycastHit2D temp in hit3)
        {
            foreach (RaycastHit2D temp1 in hit1)
            {
                if (temp.collider != null && temp.collider.gameObject.CompareTag("Player"))//공격을 시작하는 인지범위
                {
                    anim.SetBool("Monster_Move", false);
                    move_Vector = Vector2.zero;

                
                }
                else if (temp1.collider != null && temp1.collider.gameObject.CompareTag("Player"))//캐릭터를 향해 움직이는 범위
                {
                    move_Vector = new Vector2(-1.0f, 0.0f);
                    anim.SetBool("Monster_Move", true);
                }

            }
        }

        foreach (RaycastHit2D temp in hit4)
        {
            foreach (RaycastHit2D temp1 in hit2)
            {

                if (temp.collider != null && temp.collider.gameObject.CompareTag("Player"))//공격을 시작하는 인지범위
                {
                    anim.SetBool("Monster_Move", false);
                    move_Vector = Vector2.zero;

                }
                if (temp1.collider != null && temp1.collider.gameObject.CompareTag("Player"))//&& hit2.collider.gameObject.CompareTag("Player"))
                {
                    move_Vector = new Vector2(1.0f, 0.0f);
                    anim.SetBool("Monster_Move", true);
                }
            }
        }
        move_transform.Translate(move_Vector * move_speed * Time.deltaTime);
    }
    
    private void Death()
    {
        if (enemyHP.getHp() < 0)
        {
            Destroy(gameObject);
        }
    }
    private void initDamagePositoin()
    {
        damageLocation.x = transform.position.x;
        damageLocation.y = transform.position.y;
        damageLocation.z = transform.position.z;
    }
}
