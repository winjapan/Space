using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingMove : MonoBehaviour
{
    public Image Setting;
    public Image Title;
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
        Setting.gameObject.SetActive(true);
        Title.gameObject.SetActive(false);
    }
}
