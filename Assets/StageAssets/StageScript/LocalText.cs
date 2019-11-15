using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalText : MonoBehaviour
{
    public string jpText;
    public string enText;
    public string cnText;
    public Text Nativelanguage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int dummyCount = 0;
        for (int i = 0; i < 10000; i++)
        {
            dummyCount += 1;
        }

        switch (EnumLocal.language)
        {
            case EnumLocal.Language.Japanese:
                Nativelanguage.text = jpText;
                break;
            case EnumLocal.Language.English:
                Nativelanguage.text = enText;
                break;
            case EnumLocal.Language.Chinese:
                Nativelanguage.text = cnText;
                break;
                

        }
    }
}
