using UnityEngine;
using System.Collections;

public class Boss {
    private int hp = 100;           //体力
    private int power = 25;         //攻撃力

    // int型の変数mpを宣言し、53で初期化
    int MP = 53;




   //mpを消費して魔法攻撃をするMagic関数を作成
   public void Magic(int m)
    {
        Debug.Log(m + "のMPを消費した");


        //Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示。
        //mpが足りない場合、「MPが足りないため魔法が使えない。」と表示。
        if (MP >= 5)
        {
            this.MP -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + MP.ToString());
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");

        }

    }
}

public class Test : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

       

        for (int i= 0; i < 15; i += 1)
        {
            lastboss.Magic(5);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}