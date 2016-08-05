/*
作者名称:YHB

脚本作用:时间

建立时间:2016.8.5.17.32
*/

using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    #region 字段
    const float hours = 360 / 12f;//一小时的角度
    const float minutes = 360 / 60f;//一分钟的角度
    const float seconds = 360 / 60f;//一秒钟的角度

    public Toggle toggle;

    private Transform hour, minute, second;//外部拖入的时针分针秒针
    private bool isAnalog = false;
    #endregion

    #region Unity内置函数
    void Awake()
    {
        hour = this.transform.FindChild("HourCentre").transform;
        minute = this.transform.FindChild("MnuterCentre").transform;
        second = this.transform.FindChild("SecondCentre").transform;

        toggle.isOn = false;
    }
    void Update()
    {
        isAnalog = toggle.isOn;

        NowTimeRotation();
    }
    #endregion

    #region 根据当前时间转动对应的时针分针秒针
    void NowTimeRotation()
    {
        DateTime time = DateTime.Now;//获取系统当前的时间

        if (!isAnalog)
        {
            hour.localRotation = Quaternion.Euler(0, -time.Hour * hours, 0);
            minute.localRotation = Quaternion.Euler(0, -time.Minute * minutes, 0);
            second.localRotation = Quaternion.Euler(0, -time.Second * seconds, 0);
        }
        else
        {
            TimeSpan timeSpan = DateTime.Now.TimeOfDay;//更加精细的时间

            hour.localRotation = Quaternion.Euler(0, -(float)timeSpan.TotalHours * hours, 0);
            minute.localRotation = Quaternion.Euler(0, -(float)timeSpan.TotalMinutes * minutes, 0);
            second.localRotation = Quaternion.Euler(0, -(float)timeSpan.TotalSeconds * seconds, 0);
        }
    }
    #endregion
}
