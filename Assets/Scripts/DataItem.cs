

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataItem : MonoBehaviour
{
    //数据上挂载的Text
    public Text text;

    public void SetInfo(ItemData data)
    {
        this.text.text = data.userName;
    }
}
