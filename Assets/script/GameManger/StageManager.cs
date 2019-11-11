using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StageManager : MonoBehaviour {
    public int MapSize = 10;

    private static int[] Stage;
    private static int count;
    // Use this for initialization
    void Start()
    {
        count = 0;
        //랜덤 맵 생성을 위한 배열 생성
        Stage = new int[MapSize];
        System.Random random = new System.Random();
        for (int i = 0; i < MapSize; i++)
        {
            do
            {
                Stage[i] = random.Next(0, 3);
            } while (i > 0 && Stage[i] == Stage[i - 1]);
        }

    }

    // Update is called once per frame
    void Update () {
        
	}
    public int getNextStage()
    {
        if (count < MapSize)
        {
            count++;
            return Stage[count];
        }
        else
        {
            count = 0;
            return -1;
        }
    }
    public int getPreStage()
    {

        if (count != 0)
        {
            count--;
            return Stage[count];
        }
        else return -1;

    }
}
