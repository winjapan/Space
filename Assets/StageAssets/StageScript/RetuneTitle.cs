﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RetuneTitle : MonoBehaviour
{
    public Image Title;
    public Image Tutolial;
    public AudioClip button;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClicked()
    {
        audioSource.PlayOneShot(button);
        Title.gameObject.SetActive(true);
        Tutolial.gameObject.SetActive(false);
    }
}
