/*
作者名称:YHB

脚本作用:电子时钟

建立时间:2016.8.5.18.50
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Time : MonoBehaviour
{
    #region 字段
    private Text h;
    private Text m;
    private Text s;
    #endregion

    #region Unity内置函数
    void Awake()
    {
        h = this.transform.FindChild("H").GetComponent<Text>();
        m = this.transform.FindChild("M").GetComponent<Text>();
        s = this.transform.FindChild("S").GetComponent<Text>();
    }
    void Update()
    {
        TimeUpdate();
    }
    #endregion

    #region 计时
    void TimeUpdate()
    {
        DateTime time = DateTime.Now;

        int hour = time.Hour;
        int minute = time.Minute;
        int second = time.Second;

        if (hour < 10 && hour > 0)
        {
            h.text = "0" + time.Hour;
        }
        else if (hour > 9)
        {
            h.text = time.Hour.ToString();
        }
        else
        {
            h.text = "00";
        }

        if (minute < 10 && minute > 0)
        {
            m.text = "0" + time.Minute;
        }
        else if (hour > 9)
        {
            m.text = time.Minute.ToString();
        }
        else
        {
            m.text = "00";
        }

        if (second < 10 && second > 0)
        {
            s.text = "0" + time.Second;
        }
        else if (second > 9)
        {
            s.text = time.Second.ToString();
        }
        else
        {
            s.text = "00";
        }

        /*h.text = time.Hour.ToString();
        m.text = time.Minute.ToString();
        s.text = time.Second.ToString();*/
    }
    #endregion
}
