
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class pikaButton : MonoBehaviour
{
    public Sprite pikaimg;
    private Sprite originImg;
    void Start()
    {
        originImg = GetComponent<SpriteRenderer>().sprite;
    }
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = pikaimg;
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().sprite = originImg;
    }

}
