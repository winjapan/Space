using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditMove : MonoBehaviour
{
    public GameObject Spaceship;
    public GameObject Credit;
    public GameObject Earth;

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
        Spaceship.SetActive(false);
        Credit.SetActive(true);
        Earth.SetActive(true);
    }
}
