using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMap : MonoBehaviour
{

    //オブジェクトを宣言
    public GameObject Asteroid1;
    public GameObject Asteroid2;

    //ランダム數値の制禦
    private int randomMin = 1;
    private int randomMax = 3;

    //配列の幅
    public int m_width = 5; //x軸方向
    public int m_heigt = 5;//y軸方向



    // Use this for initialization
    void Start()
    {

   //上段のアステロイド
        int[,] map = new int[m_width, m_heigt];

        //for文を用ゐて各インデックスに1もしくは0を代入
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                map[i, j] = Random.Range(randomMin, randomMax);
            }
        }

        //各インデックスに代入された値を基に、壁の生成、不生成を判別
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                //インデックスの値が1の時、wallPrefabを生成
                if (map[i, j] == 1)
                {
                    GameObject ast1 = Instantiate(Asteroid1);
                    ast1.transform.position = new Vector3(i * 750, 0, j *1000);

                }
            }
        }
        //下段のアステロイド
        int[,]　downmap = new int[m_width, m_heigt];

        //for文を用ゐて各インデックスに1もしくは0を代入
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                map[i, j] = Random.Range(randomMin, randomMax);
            }
        }

        //各インデックスに代入された値を基に、壁の生成、不生成を判別
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                //インデックスの値が1の時、wallPrefabを生成
                if (map[i, j] == 1)
                {
                    GameObject ast2 = Instantiate(Asteroid2);
                    ast2.transform.position = new Vector3(i * 450, -500, j * 1000);

                }
            }
        }
    }
}
