using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Lotation : MonoBehaviour {
    public Player_Move player;
    public float lotationSpeed;

    private Vector3 L_targetVector;
    private Vector3 R_targetVector;
    private SpriteRenderer transRender;
    // Use this for initialization
    void Start()
    {
        transRender = gameObject.GetComponentInChildren<SpriteRenderer>();
        L_targetVector = new Vector3(-3.5f, -0f, -1.0f);
        R_targetVector = new Vector3(3.5f, -0f, -1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        MovePosition();
    }
    private void MovePosition()
    {
        if (player.getDirX() == 0)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, L_targetVector, lotationSpeed);
        }
        else if (player.getDirX() == 1)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, R_targetVector, lotationSpeed);
        }
    }
}
