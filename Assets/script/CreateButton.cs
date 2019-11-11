using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateButton : MonoBehaviour
{
    public GameObject button;
    private Vector3 buttonLocation;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)//객체끼리 만났을때 발동하는 함수
    {
        if (collision.CompareTag("Player"))
        {

            Debug.Log("플레이어 들어옴");
            buttonLocation.x = transform.position.x ;
            buttonLocation.y = transform.position.y + 3;
            buttonLocation.z = transform.position.z - 1;
            Instantiate(button, buttonLocation, Quaternion.identity);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)//객체랑 떨어지면 발동하는 함수
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(GameObject.Find("GetItem(Clone)"));
        }
    }
}
