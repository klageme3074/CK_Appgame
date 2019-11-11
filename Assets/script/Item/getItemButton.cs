using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getItemButton : MonoBehaviour {
    public itemWindow window;
    public delitemObject delitem;
    
    private Vector3 vector;

    // Use this for initialization
    private void Awake()
    {
        vector = transform.localPosition;
        vector.z -= 3.7f;
        vector.y -= 1.5f;
    }
    private void OnMouseUpAsButton()
    {
        InitWindowPos();
        Instantiate(window, vector, Quaternion.identity);
        vector.z += 0.1f;
        Instantiate(delitem, vector, Quaternion.identity);
        Destroy(gameObject);
    }
    private void InitWindowPos()
    {
        vector.x = transform.position.x;
        vector.y = transform.position.y -1.5f;
        vector.z = transform.position.z;
    }
}
