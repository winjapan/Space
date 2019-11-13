using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateItem : MonoBehaviour
{
    public GameObject Item;
    private int randomMin = 1;
    private int randomMax = 3;

    //配列の幅
    public int m_width = 2; //x軸方向
    public int m_heigt = 2;//y軸方向

    // Start is called before the first frame update
    void Start()
    {
        int[,] map = new int[m_width, m_heigt];

       

        //上段アステロイドのアイテム群（アイテムは、アステロイドの数よりも少なめ程度で）
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
                    GameObject item1 = Instantiate(Item);
                    item1.transform.position = new Vector3(i * 420, -150, j * 1500);

                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
