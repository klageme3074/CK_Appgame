using UnityEngine;
using UnityEngine.EventSystems;

public class Button_on_Click : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    private bool touch;
    
    void Start()
    {
        touch = false;
    }

    public virtual void OnDrag(PointerEventData ped)//이미지 범위 지정
    {
       touch = true;
    }
    public virtual void OnPointerDown(PointerEventData ped)//터치를 하고있는중에 활성화 되는 함수
    {
        OnDrag(ped);
    }

    public virtual void OnPointerUp(PointerEventData ped)//터치를 끝냈을 때 발생하는 함수
    {
        touch = false;
    }
    public bool gettouch() { return touch; }
}
