using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditMove : MonoBehaviour
{
    public GameObject Spaceship;
    public GameObject Credit;
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
        Spaceship.SetActive(false);
        Credit.SetActive(true);
    }
}
