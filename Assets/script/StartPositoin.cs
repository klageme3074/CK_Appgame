using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPositoin : MonoBehaviour {
    
    private GameObject playerObj;
    Vector3 playerLotaion;
    // Use this for initialization
    void Start()
    {
        playerLotaion = transform.position;
        playerLotaion.z -= 0.2f;
        playerLotaion.y += 2f;
        playerObj = GameObject.Find("Player").transform.gameObject;
        playerObj.transform.position = playerLotaion;
    }
	
	// Update is called once per frame
	void Update () {

        
    }
}
