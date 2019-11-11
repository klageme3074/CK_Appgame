using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleByLight : MonoBehaviour {

    private Color show;
    private Color notShow;
    // Use this for initialization
    void Start()
    {
        show = new Color(1, 1, 1, 1);
        notShow = new Color(1, 1, 1, 0);
        GetComponent<SpriteRenderer>().color = notShow;
    }
	
	// Update is called once per frame
	void Update () {

    }
    private void OnTriggerEnter2D(Collider2D collision)//객체끼리 만났을때 발동하는 함수
    {
        if (collision.CompareTag("Light"))
        {
            GetComponent<SpriteRenderer>().color = show;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)//객체랑 떨어지면 발동하는 함수
    {
        if (collision.CompareTag("Light"))
        {
            Debug.Log("적이 안보인다");
            GetComponent<SpriteRenderer>().color = notShow;
        }
    }
}
