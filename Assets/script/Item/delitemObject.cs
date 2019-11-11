using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delitemObject : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}

    private void OnMouseUpAsButton()
    {
        Destroy(GameObject.Find("dead"));
        Destroy(GameObject.Find("itemWindow(Clone)"));
        Destroy(gameObject);
    }
}
