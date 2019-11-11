using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemWindow : MonoBehaviour
{
    public Item item1;
    public Item item2;
    public Item item3;

    public int itemCode { get; set; }
    public int itemCode1;
    public int itemCode2;
    public int itemCode3;

    public int randPersent1;
    public int randPersent2;
    public int randPersent3;

    Transform itemvector;
    Vector3 tmpvector;
    GameObject temp;

    private void Start()
    {
        itemvector = transform;
        CreateItem();
    }

    void CreateItem()//나중에 함수로 정리할 것
    {
        int rand = Random.Range(1, 100);
        
        if (rand < randPersent1)
            itemCode = itemCode1;
        else
            itemCode = 9;
        temp = Instantiate(item1,itemvector).gameObject;
        temp.transform.position += new Vector3(0, 1.8f, -1f);

        rand = Random.Range(1, 100);
        
        if (rand < randPersent1)
            itemCode = itemCode2;
        else
            itemCode = 9;

        temp = Instantiate(item2, itemvector).gameObject;
        temp.transform.position += new Vector3(0, 0.0f, -1f);


        rand = Random.Range(1, 100);
        
        if (rand < randPersent1)
            itemCode = itemCode3;
        else
            itemCode = 9;

        temp = Instantiate(item3, itemvector).gameObject;
        temp.transform.position += new Vector3(0, -1.8f, -1f);
    }
}
