using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float shipSpeed = 20000;
    public float accel = 5;

    private Rigidbody rgbody;
    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody>();
        rgbody.AddForce(Vector3.forward * shipSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
