using UnityEngine;
using UnityEngine.EventSystems;

public class SwapButton : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{

    public Set_Player_Data player_data;
    public int wephoneType { get; set; }
    // Use this for initialization
    void Start()
    {
        wephoneType = 0;
    }
    
    public virtual void OnDrag(PointerEventData ped)//이미지 범위 지정
    {
    }
    public virtual void OnPointerDown(PointerEventData ped)//터치를 하고있는중에 활성화 되는 함수
    {
    }

    public virtual void OnPointerUp(PointerEventData ped)//터치를 끝냈을 때 발생하는 함수
    {
        wephoneType++;
        wephoneType %= 3;

        player_data.anim.SetInteger("Player_Weapon", wephoneType);
    }


}
