using UnityEngine;
using System.Collections.Generic;

public class YouCode : MonoBehaviour
{
    //你的代碼寫在這裡,這個腳本綁在mainCamare上
    private ButtonClint link;

    public void SetLink(ButtonClint link)
    {
        this.link = link;
    }
    //下面這些方法裏面是我隨便寫的,你要將它們改成為合適的作用
    public void WhenUp()//向上拖動時呼叫的方法,想知道為什麼去看ClickListener.cs
    {
        link.turnOn();
    }
    public void WhenDown()//向下拖動時呼叫的方法
    {
        link.turnOff();
    }
    public void WhenLeft()//向左拖動時呼叫的方法
    {
        link.turnDown();
        //tool.DestoryUnits(temp);
    }
    public void WhenRight()//向右拖動時呼叫的方法
    {
        link.turnUp();
    }
    void Start()
    {
        
        link = new TV();
    }
    public void DoubleClick()
    {
        if(link.GetType()==new TV().GetType())
        {
            link = new Air();
        }
        else
        {
            link = new TV();
        }
    }
   void OnGUI()
    {
        GUIStyle nameStyle = new GUIStyle();
        nameStyle.fontSize = 20;
        nameStyle.normal.textColor = Color.gray;

        GUIStyle numStyle = new GUIStyle();
        numStyle.fontSize = 30;
        GUI.Label(new Rect(250,10,100,40),link.GetDeviceName(),nameStyle);
        GUI.Label(new Rect(250, 40, 100, 40), link.GetShowNum(), numStyle);


    }
}
