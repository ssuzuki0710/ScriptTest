using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] points = new int[5];

        // 配列の各要素に値を代入する
        points[0] = 77;
        points[1] = 18;
        points[2] = 50;
        points[3] = 68;
        points[4] = 99;

        // 配列の要素をすべて表示する(正順)
        for (int array = 0; array < 5; array++)
        {
            Debug.Log(points[array]);
        }

        // 配列の要素をすべて表示する(逆順)
        for (int array = 4; array >= 0; array--)
        {
            Debug.Log(points[array]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}