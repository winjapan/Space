﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StartDirector : MonoBehaviour
{
    public Image Title;
    public Image result;

    public GameObject Earth;
    public GameObject BlackHoles;
    public GameObject Map;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClicked()
    {
        Title.gameObject.SetActive(false);
        result.gameObject.SetActive(true);
        GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = true;
        GameObject.Find("StarSparrow1").GetComponent<PlayerController>().enabled = true;
        Map.SetActive(true);
        Earth.SetActive(true);

    }
}
