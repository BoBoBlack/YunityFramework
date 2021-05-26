using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 任务步骤数据结构
/// </summary>
[Serializable]
public class TaskTableInfo
{
    /// <summary>
    /// 实验编号
    /// </summary>
    public int ExperimentId { get; set; }
    /// <summary>
    /// 步骤索引
    /// </summary>
    public int StepIndex { get; set; }
    /// <summary>
    /// 大步骤编号
    /// </summary>
    public int GroupId { get; set; }
    /// <summary>
    /// 大步骤名称
    /// </summary>
    public string GroupName { get; set; }
    /// <summary>
    /// 步骤事件编号
    /// </summary>
    public int StepId { get; set; }
    /// <summary>
    /// 步骤名称
    /// </summary>
    public string StepName { get; set; }
    /// <summary>
    /// 步骤完成次数
    /// </summary>
    public int StepCount { get; set; }
    /// <summary>
    /// 关联的器材
    /// </summary>
    public List<StepPropsInfo> AssoProps { get; set; }
    /// <summary>
    /// 半解锁的器材
    /// </summary>
    public List<StepPropsInfo> HalfUnLockProps { get; set; }
    /// <summary>
    /// 高亮器材
    /// </summary>
    public List<StepPropsInfo> HighlightProps { get; set; }
    /// <summary>
    /// 提示泡泡类型
    /// </summary>
    public TooltipType AssoTipType { get; set; }
    /// <summary>
    /// 关联的UI提示泡泡
    /// </summary>
    public List<int> AssoTips { get; set; }
    /// <summary>
    /// 关联的器材提示泡泡
    /// </summary>
    public List<StepTipsInfo> PropsAssoTips { get; set; }
    /// <summary>
    /// 关联的提示泡泡
    /// </summary>
    public List<string> AssoNotices { get; set; }
    /// <summary>
    /// 关联的旁白音效
    /// </summary>
    public List<string> AssoSounds { get; set; }
    /// <summary>
    /// 判断参数1-4
    /// </summary>
    public object JudgeParam1 { get; set; }
    public object JudgeParam2 { get; set; }
    public object JudgeParam3 { get; set; }
    public object JudgeParam4 { get; set; }
}
