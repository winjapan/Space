using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumLocal : MonoBehaviour
{
    public enum Language
    {
        Japanese,
        English,
        Chinese
    }

    public static Language language;
    private AudioSource audioSource;

    public AudioClip button2;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void LocalJpClicked()
    {
        language = Language.Japanese;
        audioSource.PlayOneShot(button2);
    }

    public void LocalEnClicked()
    {
        language = Language.English;
        audioSource.PlayOneShot(button2);
    }

    public void LocalCnClicked()
    {
        language = Language.Chinese;
        audioSource.PlayOneShot(button2);
    }
}
