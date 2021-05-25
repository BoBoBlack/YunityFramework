using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �¼���Ϣ������
/// </summary>
public class TaskEventManager : QSingleton<TaskEventManager>
{
    public delegate void TaskEventDel(int eventTypeId, TaskEventArgs e);         // ί�о��

    private Dictionary<int, List<TaskEventDel>> eventDic = new Dictionary<int, List<TaskEventDel>>();

    /// <summary>
    /// ע������¼�
    /// </summary>
    /// <param name="eventType"></param>
    /// <param name="eventDel"></param>
    public void RegEvent(int eventType, TaskEventDel eventDel)
    {
        if(eventDic!=null)
        {
            if (!eventDic.ContainsKey(eventType))
                eventDic.Add(eventType, new List<TaskEventDel>());
            eventDic[eventType].Add(eventDel);
        }
    }
    /// <summary>
    /// ��������¼�
    /// </summary>
    /// <param name="eventType"></param>
    /// <param name="eventDel"></param>
    public void UnRegEvenet(int eventType, TaskEventDel eventDel)
    {
        if (eventDic != null && eventDic.ContainsKey(eventType))
            eventDic[eventType].Remove(eventDel);
    }
    /// <summary>
    /// �׳��¼�
    /// </summary>
    /// <param name="eventType"></param>
    /// <param name="e"></param>
    public void PushEvent(int eventType, TaskEventArgs e)
    {
        if(eventDic!=null&& eventDic.ContainsKey(eventType))
        {
            List<TaskEventDel> list = eventDic[eventType];
            if(list!=null&&list.Count>0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] != null)
                        list[i].Invoke(eventType, e);
                }
            }
        }
    }

    public override void Clear()
    {
        throw new System.NotImplementedException();
    }

    public override void OnReConnect()
    {
        throw new System.NotImplementedException();
    }

    public override void OnUpdate(float deltaTime)
    {
        throw new System.NotImplementedException();
    }

    protected override void OnInit()
    {
        throw new System.NotImplementedException();
    }
 
}
