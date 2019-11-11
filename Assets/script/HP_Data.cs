using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Data : MonoBehaviour
{
    private float HP;

    public HP_Data(float _HP)//생성자
    {
        HP = _HP;
    }
    //Enemy_Data enemy= new Enemy(50) 체력이 50인 적의 데이터

    public void decreaseHP(float damage)
    {
        HP -= damage;
    }
    //Enemy_Data enemy= new Enemy(50) == 체력이 50인 적의 데이터.
    //enrmy.decreaseHP(20) == 체력을 20만큼 깎는다.
    public float getHp()
    {
        return HP;
    }
    //Enemy_Data enemy = new Enemy_Data(50); == 체력이 50인 적의 데이터
    //enemy.getHp(); == 현재 체력을 반환
}

