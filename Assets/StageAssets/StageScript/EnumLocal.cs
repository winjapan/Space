using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumLocal : MonoBehaviour
{
    public enum Language
    {
        Japanese,
        English,
        Chinese
    }

    public static Language language;

  public void LocalJpClicked()
    {
        language = Language.Japanese;
    }

    public void LocalEnClicked()
    {
        language = Language.English;
    }

    public void LocalCnClicked()
    {
        language = Language.Chinese;
    }
}
