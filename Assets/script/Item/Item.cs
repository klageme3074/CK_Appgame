using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    public int itemcode { get; set; }//아이템 코드 
    public int AR_bullet = 30;
    public int HG_bullet = 30;
    public Sprite endItem1;
    public Sprite endItem2;
    public Sprite endItem3;
    public Sprite endItem4;
    public Sprite healItem;
    public Sprite fullhealItem;
    public Sprite AR_imge;
    public Sprite AR_BulletImge;
    public Sprite HG_BulletImge;
    public Sprite emptyImge;

    private itemWindow itemWindow;
    private Player_HP player_HP;
    private Inbentory inbentory;
    //아이템코드 0~3 엔딩에 필요한 아이템, 5~6 체력아이템, 
    private void Awake()
    {

        player_HP = GameObject.Find("Player").GetComponent<Player_HP>();
        inbentory = GameObject.Find("Player").GetComponent<Inbentory>();
        itemWindow = GameObject.Find("itemWindow(Clone)").GetComponent<itemWindow>();
        itemcode = itemWindow.itemCode;
        switch (itemcode)
        {
            case 0:
                GetComponent<SpriteRenderer>().sprite = endItem1;
                break;
            case 1:
                GetComponent<SpriteRenderer>().sprite = endItem2;
                break;
            case 2:
                GetComponent<SpriteRenderer>().sprite = endItem3;
                break;
            case 3:
                GetComponent<SpriteRenderer>().sprite = endItem4;
                break;
            case 4:
                GetComponent<SpriteRenderer>().sprite = healItem;
                break;
            case 5:
                GetComponent<SpriteRenderer>().sprite = fullhealItem;
                break;
            case 6:
                GetComponent<SpriteRenderer>().sprite = AR_imge;
                break;
            case 7:
                GetComponent<SpriteRenderer>().sprite = AR_BulletImge;
                break;
            case 8:
                GetComponent<SpriteRenderer>().sprite = HG_BulletImge;
                break;
            default:

                break;
        }

    }
    private void OnMouseDown()
    {
        switch (itemcode)
        {
            case 0:
                inbentory.endingitem1 = true;
                Destroy(gameObject);
                break;
            case 1:
                inbentory.endingitem2 = true;
                Destroy(gameObject);
                break;
            case 2:
                inbentory.endingitem3 = true;
                Destroy(gameObject);
                break;
            case 3:
                inbentory.endingitem4 = true;
                Destroy(gameObject);
                break;
            case 4:
                player_HP.HP += 20f;
                Destroy(gameObject);
                break;
            case 5:
                player_HP.HP = player_HP.fullHP;
                Destroy(gameObject);
                break;
            case 6:
                if(inbentory.AR)
                    inbentory.AR_bullet += AR_bullet;
                else
                inbentory.AR = true;
                Destroy(gameObject);
                break;
            case 7:
                inbentory.AR_bullet += AR_bullet;
                Destroy(gameObject);
                break;
            case 8:
                inbentory.HG_bullet += HG_bullet;
                Destroy(gameObject);
                break;
            default:

                break;
        }
    }
}
