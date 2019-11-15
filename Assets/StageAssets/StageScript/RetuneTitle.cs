using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RetuneTitle : MonoBehaviour
{
    public Image Title;
    public Image Tutolial;
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
        Title.gameObject.SetActive(true);
        Tutolial.gameObject.SetActive(false);
    }
}
