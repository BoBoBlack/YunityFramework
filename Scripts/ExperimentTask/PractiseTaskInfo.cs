using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ϰģʽʵ��������Ϣ
/// </summary>
[Serializable]
public class PractiseTaskInfo
{
    public int ExperimentId = -1;               // ʵ��Id
    public string ExperimentName = "";          // ʵ������
    public List<PractiseTaskStepInfo> StepSetList = null;       // ��ʵ������������

    public bool IsExperimentSuccess = false;    // ʵ���Ƿ����

    public int CurStepIndex = -1;               // ��ǰִ�е����������
}
