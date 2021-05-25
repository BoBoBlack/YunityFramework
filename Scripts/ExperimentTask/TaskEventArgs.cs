using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ������Ϣ������
/// </summary>
public class TaskEventArgs : EventArgs
{
    public GameObject Sender { get; set; } = null;      // ������
    public int CorrectEventId { get; set; } = 0;      // ��ȷ�¼���Id

    public object Param1 { get; set; } = null;          // ����1
    public object Param2 { get; set; } = null;          // ����2
    public object Param3 { get; set; } = null;          // ����3
    public object Param4 { get; set; } = null;          // ����4

    public TaskEventArgs()
    {
    }
    #region ���������Ĺ��캯��
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
