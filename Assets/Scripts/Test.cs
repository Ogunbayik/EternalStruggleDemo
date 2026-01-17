using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int testForOdd;
    public float degree;

    public bool isEven;

    void Start()
    {
        /*
        for (int i = 0; i < testForOdd; i++)
        {
            var test = (float)i / 2;
            var isOdd = i / 2;
            test = Mathf.CeilToInt(test);

            if (isOdd != 0)
                test = -test;
            
            Debug.Log(test);
        }
        */
        for (int i = 0; i < testForOdd; i++)
        {
            // i = 0 iken -> 0
            // i = 1 iken -> 1
            // i = 2 iken -> -1
            // i = 3 iken -> 2
            // i = 4 iken -> -2 ...

            float step = Mathf.Ceil(i / 2f);
            float sign = (i % 2 == 0) ? 1 : -1;
            float finalOffset = step * sign * degree;

            if (i == 0) finalOffset = 0; // Ýlk mermi tam merkezde

            Debug.Log($"Mermi {i} Offset: {finalOffset}");
        }
    }

}
