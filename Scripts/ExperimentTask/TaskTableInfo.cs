using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ʵ����������ݽṹ
/// </summary>
[Serializable]
public class TaskTableInfo
{
    /// <summary>
    /// ʵ����
    /// </summary>
    public int ExperimentId { get; set; }
    /// <summary>
    /// ��������
    /// </summary>
    public int StepIndex { get; set; }
    /// <summary>
    /// ������
    /// </summary>
    public int GroupId { get; set; }
    /// <summary>
    /// ��������
    /// </summary>
    public string GroupName { get; set; }
    /// <summary>
    /// �����¼����
    /// </summary>
    public int StepId { get; set; }
    /// <summary>
    /// ��������
    /// </summary>
    public string StepName { get; set; }
    /// <summary>
    /// ������ɴ���
    /// </summary>
    public int StepCount { get; set; }
    /// <summary>
    /// ����������
    /// </summary>
    public List<StepPropsInfo> AssoProps { get; set; }
    /// <summary>
    /// �����������
    /// </summary>
    public List<StepPropsInfo> HalfUnLockProps { get; set; }
    /// <summary>
    /// ��������
    /// </summary>
    public List<StepPropsInfo> HighlightProps { get; set; }
    /// <summary>
    /// ��ʾ��������
    /// </summary>
    public TooltipType AssoTipType { get; set; }
    /// <summary>
    /// ������UI��ʾ����
    /// </summary>
    public List<int> AssoTips { get; set; }
    /// <summary>
    /// ������������ʾ����
    /// </summary>
    public List<StepTipsInfo> PropsAssoTips { get; set; }
    /// <summary>
    /// ��������ʾ����
    /// </summary>
    public List<string> AssoNotices { get; set; }
    /// <summary>
    /// �������԰���Ч
    /// </summary>
    public List<string> AssoSounds { get; set; }
    /// <summary>
    /// �жϲ���1-4
    /// </summary>
    public object JudgeParam1 { get; set; }
    public object JudgeParam2 { get; set; }
    public object JudgeParam3 { get; set; }
    public object JudgeParam4 { get; set; }
}
