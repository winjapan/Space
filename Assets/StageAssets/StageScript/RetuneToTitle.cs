using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetuneToTitle : MonoBehaviour
{
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
        Invoke("Reset",0.5f);
    }

    private void Reset()
    {
        SceneManager.LoadScene("GameScene");
    }
}
