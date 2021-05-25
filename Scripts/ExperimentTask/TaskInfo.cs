using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 任务数据结构类
/// </summary>
[Serializable]
public class TaskInfo
{
    /// <summary>
    /// 任务所属模块编号
    /// </summary>
    public int TaskModuleId{ get; set; }
    /// <summary>
    /// 任务编号
    /// </summary>
    public int TaskId { get; set; }
    /// <summary>
    /// 任务名称
    /// </summary>
    public string TaskName { get; set; }
    /// <summary>
    /// 任务图标名称
    /// </summary>
    public string TaskIconName { get; set; }
    /// <summary>
    /// 任务内容
    /// </summary>
    public string TaskContent { get; set; }

}
