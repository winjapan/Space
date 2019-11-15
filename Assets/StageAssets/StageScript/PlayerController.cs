using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public float shipSpeed = 50000;
    public float accel = 5;

    private Rigidbody rgbody;
    private Animator animator;

    public GameObject Explode;
    public GameObject Warp;
    public GameObject BlackHoles;

    public Text Clear;
    public Text GameOver;
  
    public Animator SFanima;
    public Image resultImg;
    public Button titleButton;

    public GameObject Map;
    public GameObject Point;
    public GameObject Siren;

    public ScoreResult scoreResult;
    private AudioSource audioSource;

    public AudioClip Speed;
    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        rgbody.AddForce(Vector3.forward * shipSpeed);
        audioSource = GetComponent<AudioSource>();
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
           

            shipSpeed = 0;
            Debug.Log(shipSpeed);
            rgbody.useGravity = true;
            var ex = Instantiate(Explode, this.transform.position, Quaternion.identity);
            BlackHoles.SetActive(false);
            GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = false;
            Destroy(Map);
            Siren.SetActive(true);
            animator.SetTrigger("Destroy");
            Invoke("Stop",4f);
        }
        if (other.gameObject.tag == "Out")
        {
            rgbody.useGravity= true;

            shipSpeed = 0;
            var ex = Instantiate(Explode, this.transform.position, Quaternion.identity);
            BlackHoles.SetActive(false);
            GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = false;
            Destroy(Map);
            Siren.SetActive(true);
            animator.SetTrigger("Destroy");
            Invoke("Stop", 4f);
        }
    }

    void Stop()
    {
        rgbody.isKinematic = true;
        SFanima.enabled = true;
        this.enabled = false;
        GameOver.gameObject.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Energy")
        {
            StartCoroutine(SpeedUp());
            audioSource.PlayOneShot(Speed);
        }
        if (other.gameObject.tag == "Earth")
        {
            GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = false;
            Clear.gameObject.SetActive(true);
            SFanima.enabled = true;

            StartCoroutine(SpeedDown());
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

    IEnumerator SpeedDown()
    {
        shipSpeed = 20000;

        yield return new WaitForSeconds(0.5f);
        rgbody.isKinematic = true;
        shipSpeed = 0;
    
    }
}


//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
