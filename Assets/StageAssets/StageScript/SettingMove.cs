using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingMove : MonoBehaviour
{
    public Image Setting;
    public Image Title;

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
        Setting.gameObject.SetActive(true);
        Title.gameObject.SetActive(false);
    }
}
