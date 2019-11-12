using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float shipSpeed = 20000;
    public float accel = 5;

    private Rigidbody rgbody;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        rgbody.AddForce(Vector3.forward * shipSpeed);
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up * accel;
            animator.SetBool("Up", true);
        }
        else
        {
            animator.SetBool("Up", false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.up * accel;
            animator.SetBool("Down", true);
        }
        else
        {
            animator.SetBool("Down", false);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * accel;
            animator.SetBool("Right", true);
        }
        else
        {
            animator.SetBool("Right", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * accel;
            animator.SetBool("Left", true);
        }
        else
        {
            animator.SetBool("Left", false);
        }
    }
}


//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
