using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceManajer : MonoBehaviour
{
    public Text Distance;
    public Text point;
   

   
    public int scorePoint = 5;  //プレイヤーが飛んだ距離*100をスコアとして換算する

    public int bonusScore = 1000000; //惑星に到達した時のみ、クリア換算用として使用
    public int penaltyAst = 10000; //小惑星にぶつかった時のみ、ペナルティとして加算
    public int penaltyOut = 50000;　//ブラックホール（見えないステージ壁）にぶつかった時のみ、大ペナルティとして加算

    public Button title;
   
    public GameObject Player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance.text = this.transform.position.z * scorePoint + "P".ToString();
        Debug.Log(transform.position.z * scorePoint);
    }
   
}
