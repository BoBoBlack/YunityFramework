using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 任务消息参数类
/// </summary>
public class TaskEventArgs : EventArgs
{
    public GameObject Sender { get; set; } = null;      // 发送者
    public int CorrectEventId { get; set; } = 0;      // 正确事件的Id

    public object Param1 { get; set; } = null;          // 参数1
    public object Param2 { get; set; } = null;          // 参数2
    public object Param3 { get; set; } = null;          // 参数3
    public object Param4 { get; set; } = null;          // 参数4

    public TaskEventArgs()
    {
    }
    #region 带填充参数的构造函数
    public TaskEventArgs(GameObject sender)
    {
        Sender = sender;
    }
    public TaskEventArgs(GameObject sender, int eventId)
    {
        Sender = sender;
        CorrectEventId = eventId;
    }
    public TaskEventArgs(GameObject sender, int eventId,
                        object param1 = null, object param2 = null, object param3 = null, object param4 = null)
    {
        Sender = sender;
        CorrectEventId = eventId;

        Param1 = param1;
        Param2 = param2;
        Param3 = param3;
        Param4 = param4;
    }
    #endregion
}
