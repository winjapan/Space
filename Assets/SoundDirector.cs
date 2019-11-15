﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundDirector : MonoBehaviour
{
    [SerializeField]
    private AudioMixerSnapshot gamesound;
    [SerializeField]
    UnityEngine.Audio.AudioMixer mixer;
    UnityEngine.Audio.AudioMixerSnapshot shot;
    public GameObject Director;
    AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Update()
    {
        float bgm = 0.0f;
    }

    // Start is called before the first frame update
    public void SetMaster(float valume)
    {
        mixer.SetFloat("FieldMaster", valume);
    }

    public void SetBGM(float valume)
    {
        mixer.SetFloat("FieldBGM", valume);
    }
    public void SetSE(float valume)
    {
        mixer.SetFloat("FieldSE", valume);


        Invoke("OFFSound", 1f);
        audioSource.enabled = true;
    }

    void OFFSound()
    {
        audioSource.enabled = false;
    }
}
