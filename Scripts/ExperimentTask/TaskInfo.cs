using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �������ݽṹ��
/// </summary>
[Serializable]
public class TaskInfo
{
    /// <summary>
    /// ��������ģ����
    /// </summary>
    public int TaskModuleId{ get; set; }
    /// <summary>
    /// ������
    /// </summary>
    public int TaskId { get; set; }
    /// <summary>
    /// ��������
    /// </summary>
    public string TaskName { get; set; }
    /// <summary>
    /// ����ͼ������
    /// </summary>
    public string TaskIconName { get; set; }
    /// <summary>
    /// ��������
    /// </summary>
    public string TaskContent { get; set; }

}
