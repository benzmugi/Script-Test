
using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }


    public void Magic(int damage)
    {
        if (mp >= damage)
        {
            this.mp -= damage;
            Debug.Log("魔法攻撃をした。残りMPは "+this.mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
    }
   
}
public class Test : MonoBehaviour
{

    void Start()
    {
        int[] array = new int[5];


        array[0] = 7;
        array[1] = 2;
        array[2] = 5;
        array[3] = 9;
        array[4] = 6;

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }


        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic(5);

        }

    }
}