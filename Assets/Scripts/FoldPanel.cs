
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 折叠菜单
/// </summary>
public class FoldPanel : MonoBehaviour
{
    [SerializeField]
    private GameObject panelItem; // 显示子折叠面板
    [SerializeField]
    private TitleItem titleItem;  //标题预制体
    [SerializeField]
    private DataItem dataItem;  //显示文字  认子折叠面板为爹

    //对外折叠信息获取
    public List<FoldData> dataList = new List<FoldData>();

    private void Start()
    {
        Create();
    }

    public void Create()
    {
        //根据数据的长度生成
        for (int i = 0; i < dataList.Count; i++)
        {
            // 创建标题   
            TitleItem title = Instantiate(titleItem).GetComponent<TitleItem>();
            //标题设置内容
            title.SetTitle(dataList[i].titleName);
            //认爹
            title.transform.SetParent(this.transform);
            //显示
            title.gameObject.SetActive(true);

            // 创建子折叠面板
            GameObject panel = Instantiate(panelItem);
            panel.transform.SetParent(this.transform);
            // 260是折叠页的宽度，30DataItem的高度
            //panel.GetComponent<RectTransform>().sizeDelta = new Vector3(260, 30 * dataList[i].data.Count);

            title.SetFoldPanel(panel);
            panel.SetActive(false);

            // 创建折叠页数据
            for (int j = 0; j < dataList[i].data.Count; j++)
            {
                DataItem item = Instantiate(dataItem).GetComponent<DataItem>();
                item.transform.SetParent(panel.transform);
                item.gameObject.SetActive(true);
                item.SetInfo(dataList[i].data[j]);
            }
        }
    }
}


[System.Serializable]
public class FoldData
{
    //标题名字
    public string titleName;
    //对应下面的集合
    public List<ItemData> data;
}

[System.Serializable]
public class ItemData
{
    public string userName;
    //public string imageName;
    //public Sprite imageName;
}
