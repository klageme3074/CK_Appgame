using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoolTimeButton : MonoBehaviour {

    public Button_on_Click reloadButton;
    Image reimage;

    public float cooltime = 2.0f;
    bool endCoolTime;
	// Use this for initialization
	void Start () {
        reimage = gameObject.GetComponent<Image>();
        reimage.fillAmount = 0f;
        endCoolTime = false;
    }
	
	// Update is called once per frame
	void Update () {
        CheckCoolTime();

    }
    void CheckCoolTime()
    {
        if (reloadButton.gettouch() && !endCoolTime)
        {
            endCoolTime = true;
            reimage.fillAmount = 1f;
        }
        if (endCoolTime)
        {
            if (reimage.fillAmount != 0)
            {
                reimage.fillAmount -= Time.deltaTime / cooltime;
            }
            else
            endCoolTime = false;
        }
    }
}
