using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditTimeLine : MonoBehaviour
{
    public float creditTime;
    public Text Credit1;
    public Text Credit2;
    public Text Credit3;
    public Text Credit4;
    public Text Credit5;

    public GameObject SpaceShip;
    public GameObject Credit;
    public GameObject Earth;
    // Start is called before the first frame update
    void Start()
    {
        creditTime = 55;
    }

    // Update is called once per frame
    void Update()
    {
        int dummyCount = 0;
        for (int i = 0; i < 10000; i++)
        {
            dummyCount += 1;
        }

        creditTime -= Time.deltaTime;

        if (creditTime < 50)
        {
            Credit1.gameObject.SetActive(true);
        }
        if (creditTime < 40)
        {
            Credit1.gameObject.SetActive(false);
            Credit2.gameObject.SetActive(true);
        }
        if (creditTime < 30)
        {
            Credit2.gameObject.SetActive(false);
            Credit3.gameObject.SetActive(true);
        }
        if (creditTime < 20)
        {
            Credit3.gameObject.SetActive(false);
            Credit4.gameObject.SetActive(true);
        }
        if (creditTime < 10)
        {
            Credit4.gameObject.SetActive(false);
            Credit5.gameObject.SetActive(true);
        }
        if (creditTime < 0)
        {
            Credit5.gameObject.SetActive(false);
            SpaceShip.SetActive(true);
            Credit.SetActive(false);
            Earth.SetActive(false);
            Start();
        }
    }
}
