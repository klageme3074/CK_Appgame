using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {

    public GameObject ObjectTemplate;
    public int Size;
    Stack<GameObject> Objects;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < Size; i++)
        {
            Objects.Push(Instantiate(ObjectTemplate));
        }
    }

	public GameObject Pop()
    {
        return Objects.Pop();
    }

    public void Push(GameObject gameObject)
    {
        Objects.Push(gameObject);
    }
}
