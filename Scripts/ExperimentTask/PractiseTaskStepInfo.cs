using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ϰģʽʵ�����������ݽṹ
/// </summary>
[Serializable]
public class PractiseTaskStepInfo
{
    public int StepIndex = -1;                  // ��������
    public int GroupId = -1;                    // ������
    public string GroupName = "";               // ��������
    public int StepId = -1;                     // �����¼����
    public string StepName = "";                // ��������
    public int StepCount = 0;                   // ����ִ�д���

    public TooltipType AssoTipType = TooltipType.NONE;      // ʵ�������������
    public List<int> AssoTips = null;                       // ������UI��ʾ����
    public List<StepTipsInfo> PropsAssoTips = null;         // ʵ�����Ĺ�������
    public List<string> AssoNotices = null;                 // ������ʾ����;
    public List<string> AssoSounds = null;                  // ʵ�������Ч

    public object JudgeParam1 = null;           // �жϲ���1-4
    public object JudgeParam2 = null;
    public object JudgeParam3 = null;
    public object JudgeParam4 = null;

    public int CurStepCount = 0;                // ��ǰ����ִ�д���

    public bool IsStepSuccess { get => CurStepCount != 0 && CurStepCount >= StepCount; } // �����Ƿ����
}
