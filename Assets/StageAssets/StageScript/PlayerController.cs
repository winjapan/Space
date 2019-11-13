using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float shipSpeed = 50000;
    public float accel = 5;

    private Rigidbody rgbody;
    private Animator animator;

    public GameObject Explode;
    public GameObject Warp;
    public GameObject UpBlackHole;
    public GameObject DownBlackHole;
    public GameObject LeftBlackHole;
    public GameObject RightBlackHole;
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
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Asteroid")
        {
            rgbody.isKinematic = true;

            shipSpeed = 0;
            var ex = Instantiate(Explode, this.transform.position, Quaternion.identity);
            DownBlackHole.SetActive(false);
            UpBlackHole.SetActive(false);
            LeftBlackHole.SetActive(false);
            RightBlackHole.SetActive(false);
        }
        if (other.gameObject.tag == "Out")
        {
            rgbody.isKinematic = true;
            shipSpeed = 0;
            var ex = Instantiate(Explode, this.transform.position, Quaternion.identity);
            DownBlackHole.SetActive(false);
            UpBlackHole.SetActive(false);
            LeftBlackHole.SetActive(false);
            RightBlackHole.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Energy")
        {
            StartCoroutine(SpeedUp());

        }
    }

    IEnumerator SpeedUp()
    {
        shipSpeed = 50000 + 20000;
        Debug.Log(shipSpeed);
        Warp.SetActive(true);
        yield return new WaitForSeconds(2f);

        shipSpeed = 50000;
        Debug.Log(shipSpeed);
        Warp.SetActive(false);
    }
}


//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
