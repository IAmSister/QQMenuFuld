

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataItem : MonoBehaviour
{
    //�����Ϲ��ص�Text
    public Text text;

    public void SetInfo(ItemData data)
    {
        this.text.text = data.userName;
    }
}
