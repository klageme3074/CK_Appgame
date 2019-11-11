using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCreate : MonoBehaviour {

    public float Power;
    float duration=1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (duration < 0) { Destroy(gameObject); duration = 1f; }
        duration -= Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("asdas");
           Destroy(gameObject);
        }
    }
}
