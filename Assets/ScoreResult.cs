using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreResult : MonoBehaviour
{
    public Button title;

    public Text Distance;
    public Text totalDistance;
    public Text point;
    public Text BounusScore;
    public Text totalScore;

    public GameObject Player;

    public int scorePoint = 20;  //プレイヤーが飛んだ距離×２０をスコアとして換算する
    public int bonusScore = 10000; //こちらは、もし惑星に到達した時のクリア換算用として使用

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
