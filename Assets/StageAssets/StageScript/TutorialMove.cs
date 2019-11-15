using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialMove : MonoBehaviour
{
    public Image Setting;
    public Image Tutorial;

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
        Setting.gameObject.SetActive(false);
        Tutorial.gameObject.SetActive(true);
    }
}
