using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inbentory : MonoBehaviour {

    public Text hgbulletCount;
    public Text arbulletCount;
    public bool AR { get; set; }
    public bool endingitem1 { get; set; }
    public bool endingitem2 { get; set; }
    public bool endingitem3 { get; set; }
    public bool endingitem4 { get; set; }
    public int HG_bullet { get; set; }
    public int AR_bullet { get; set; }

    int MaxHG_bullet;
    int MaxAR_bullet;

    private void Start()
    {
        HG_bullet = 10;
        AR_bullet = 30;
    }
    private void Update()
    {
        hgbulletCount.text = "HG : " + HG_bullet;
        arbulletCount.text = "AR : " + AR_bullet;
    }
    public bool Ending()
    {
        if (endingitem1 == true && endingitem2 == true &&
            endingitem3 == true && endingitem4 == true)
            return true;
        else
            return false;
    }
}
