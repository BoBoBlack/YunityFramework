using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 练习模式实验任务步骤数据结构
/// </summary>
[Serializable]
public class PractiseTaskStepInfo
{
    public int StepIndex = -1;                  // 步骤索引
    public int GroupId = -1;                    // 大步骤编号
    public string GroupName = "";               // 大步骤名称
    public int StepId = -1;                     // 步骤事件编号
    public string StepName = "";                // 步骤名称
    public int StepCount = 0;                   // 步骤执行次数

    public TooltipType AssoTipType = TooltipType.NONE;      // 实验关联泡泡类型
    public List<int> AssoTips = null;                       // 关联的UI提示泡泡
    public List<StepTipsInfo> PropsAssoTips = null;         // 实验器材关联泡泡
    public List<string> AssoNotices = null;                 // 步骤提示内容;
    public List<string> AssoSounds = null;                  // 实验关联音效

    public object JudgeParam1 = null;           // 判断参数1-4
    public object JudgeParam2 = null;
    public object JudgeParam3 = null;
    public object JudgeParam4 = null;

    public int CurStepCount = 0;                // 当前步骤执行次数

    public bool IsStepSuccess { get => CurStepCount != 0 && CurStepCount >= StepCount; } // 步骤是否完成
}
