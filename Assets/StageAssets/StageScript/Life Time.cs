﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObj",2f);
    }

    void DestroyObj()
    {
        Destroy(this.gameObject);
    }
    //// Update is called once per frame
    //void Update()
    //{

    //}
}
