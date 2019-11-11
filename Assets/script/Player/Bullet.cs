using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Bullet_Speed = 30f;
    public float Bullet_Power = 3f;
    public float Bullet_Life = 1f;
    public ObjectPool OwnerPool;
    

    // Update is called once per frame
    void Update()
    {
        if (Bullet_Life<0)
        {
            OwnerPool.Push(gameObject);
            Bullet_Life = 1f;
        }
        Bullet_Life -= Time.deltaTime;
        transform.Translate(Vector3.right * Bullet_Speed * Time.deltaTime);//총알을 오른쪽으로 발사
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //부딪히는 collsion을 가진 객체의 태그가 "Enemy"일 경우
        if (collision.CompareTag("Enemy"))
        {
            OwnerPool.Push(gameObject);
        }
    }
}
