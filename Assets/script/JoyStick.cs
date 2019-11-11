using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class JoyStick : MonoBehaviour,IDragHandler,IPointerUpHandler,IPointerDownHandler {
    private Image bgImg;
    private Image joyStickimg;
    private Vector2 inputVector;
    // Use this for initialization
    void Start () {
        bgImg = GetComponent<Image>();
        joyStickimg = transform.GetChild(0).GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {

    }
    public virtual void OnDrag(PointerEventData ped)//터치패드를 누르고 있을때
    {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(bgImg.rectTransform,ped.position,ped.pressEventCamera,out pos))//백그라운드 이미지 영역에 터치가 발생했을때
        {
            pos.x = (pos.x / bgImg.rectTransform.sizeDelta.x);//터치될 로컬값을 pos에 할당함
            inputVector = new Vector2(pos.x * 2, 0);//조이스틱이미지를기준으로 좌우로 움직일때 x는 -1~1사이의 값으로 변환한 값을 단위 벡터로 만듬
            inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;

            //조이스틱 이미지를 움직인다
            joyStickimg.rectTransform.anchoredPosition = new Vector2(inputVector.x * (bgImg.rectTransform.sizeDelta.x / 3), 0);
        }
    }

    public virtual void OnPointerDown(PointerEventData ped)//터치를 하고있는중에 활성화 되는 함수
    {
        OnDrag(ped);
    }

    public virtual void OnPointerUp(PointerEventData ped)//터치를 끝냈을 때 발생하는 함수
    {
        inputVector = Vector2.zero;
        joyStickimg.rectTransform.anchoredPosition = Vector2.zero;
    }

    public float GetHorizontalValue()
    {
        return inputVector.x;
    }
}
