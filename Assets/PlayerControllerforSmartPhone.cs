using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//プレイヤーコントローラースマートフォン対応版
public class PlayerControllerforSmartPhone : MonoBehaviour
{
    public float shipSpeed = 50000;
    public float accel = 30;
    public float rightaccel = 25;
    public float leftaccel = -25;

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

    public Button Up;
    public Button Down;
    public Button Right;
    public Button Left;

    public bool isClick;
    public bool isDown;
    public bool isRight;
    public bool isLeft;
    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        rgbody.AddForce(Vector3.forward * shipSpeed);
        audioSource = GetComponent<AudioSource>();
    }

    //フィックスドアップデートのみスマートフォン仕様に変更
    private void FixedUpdate()
    {
        //パソコンで使っている方向キー（上下左右）をスマホ用に実装していく
        //スマホのタップ位置＋上でプレイヤーのアニメーション”Up”を実行
        //スマホのタップ位ー下でプレイヤーのアニメーション”Down”を実行
        //スマホのタップ位置＋右でプレイヤーのアニメーション”Right”を実行
        //スマホのタップ位ー左でプレイヤーのアニメーション”Left”を実行
        //スマホのタップ位置が０（中央）の時は、プレイヤーのアニメーションはアイドル状態

        //animator.SetBool("Down", true);
        //animator.SetBool("Right", true);
        //animator.SetBool("Left", true);

        //
        //animator.SetBool("Down", false);
        //animator.SetBool("Right", false);
        //animator.SetBool("Left", false);

        //if (isClick == true)
        //{
        //UpButtonClicked();
        //}

        //if (isClick == false)
        //{
        //    UpButtonNoneClicked();
        //}

        if (isClick)
        {
           UpMove();
        }

        if (isDown)
        {
            DownMove();
        }

        if (isRight)
        {
            RightMove();
        }
        if (isLeft)
        {
            LeftMove();
        }
    }

    public void OnUpClickDown()
    {
       
        animator.SetBool("Up", true);
        isClick = true;
        //UpButtonNoneClicked();
    }

    public void OnUpClickUp()
    {
        isClick = false;
        animator.SetBool("Up", false);
    }

    public void UpMove()
    {
        this.transform.position += transform.up * accel;
      
    }

    public void OnDownClickDown()
    {

        animator.SetBool("Down", true);
        isClick = true;
        //UpButtonNoneClicked();
    }

    public void OnDownClickUp()
    {
        isClick = false;
        animator.SetBool("Down", false);
    }

    public void DownMove()
    {
        this.transform.position -= transform.up * accel;
    }

    public void OnRightClickDown()
    {

        animator.SetBool("Right", true);
        isClick = true;
   
        //UpButtonNoneClicked();
    }

    public void OnRightClickUp()
    {
        isClick = false;
        animator.SetBool("Right", false);
       
    }

    public void RightMove()
    {
        transform.position += transform.right * accel;
        //transform.position += transform.right *rightaccel;
        //Vector3 direction = new Vector3(accel, 0).normalized;
        //transform.Translater(1,1,1);
    }
    public void OnLeftClickDown()
    {

        animator.SetBool("Left", true);
        isClick = true;
     
        //UpButtonNoneClicked();
    }

    public void OnLeftClickUp()
    {
        isClick = false;
        animator.SetBool("Left", false);
    }

    public void LeftMove()
    {
        //transform.position -= transform.forward * accel;
        transform.position -= transform.right * accel;

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
