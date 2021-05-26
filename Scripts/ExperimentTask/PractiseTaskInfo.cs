using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 练习模式实验任务信息
/// </summary>
[Serializable]
public class PractiseTaskInfo
{
    public int ExperimentId = -1;               // 实验Id
    public string ExperimentName = "";          // 实验名称
    public List<PractiseTaskStepInfo> StepSetList = null;       // 该实验下属的任务集

    public bool IsExperimentSuccess = false;    // 实验是否完成

    public int CurStepIndex = -1;               // 当前执行的任务的索引
}
