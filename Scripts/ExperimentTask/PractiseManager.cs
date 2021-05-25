using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ϰģʽ����
/// </summary>
public class PractiseManager : QSingleton<PractiseManager>
{
    /// <summary>
    /// ���ж�ȡ������������Ϣ�ֵ�
    /// </summary>
    public Dictionary<int, List<TaskTableInfo>> ExperimentTaskDic { get; private set; } = new Dictionary<int, List<TaskTableInfo>>();
    /// <summary>
    /// �Ƿ�����ϰģʽ
    /// </summary>
    private bool mIsInPractiseMode = false;
    private int mSoundId = -1;

    public PractiseTaskInfo PraticeStepInfo { get; private set; } = null;
    public Dictionary<int, string> PraticeGroupPair { get; private set; } = null;

    /// <summary>
    /// ������ϰ
    /// </summary>
    /// <param name="expId"></param>
    public void EnterPratice(int expId)
    {
        // �ж�û���˳��Ļ����˳�
        if (mIsInPractiseMode)
        {
            LeavePratice();
        }
        if (ExperimentTaskDic != null && ExperimentTaskDic.ContainsKey(expId))
        {
            mIsInPractiseMode = true;

            TaskEventManager.GetInstance().RegEvent((int)TaskEventType.ParamNone, OnTaskStep);
            TaskEventManager.GetInstance().RegEvent((int)TaskEventType.ParamOne, OnTaskStep);
            TaskEventManager.GetInstance().RegEvent((int)TaskEventType.ParamTwo, OnTaskStep);
            TaskEventManager.GetInstance().RegEvent((int)TaskEventType.ParamThree, OnTaskStep);
            TaskEventManager.GetInstance().RegEvent((int)TaskEventType.ParamFour, OnTaskStep);

            LoadCurExperimentTask(expId);
        }
    }
    /// <summary>
    /// �˳���ǰ��ϰ����
    /// </summary>
    public void LeavePratice()
    {
       
    }
    /// <summary>
    /// ������Ϣ��Ļص�����
    /// </summary>
    void OnTaskStep(int eventTypeId, TaskEventArgs e)
    {

    }
    public void LoadCurExperimentTask(int expId)
    {
        if (!ExperimentTaskDic.ContainsKey(expId)) return;
        // ��ȡһ��������������Ϣ
        List<TaskTableInfo> info = ExperimentTaskDic[expId];

        if (info == null || info.Count <= 0) return;

        PraticeStepInfo = new PractiseTaskInfo();
        PraticeGroupPair = new Dictionary<int, string>();
        PraticeStepInfo.ExperimentId = expId;

    }
    public override void Clear()
    {

    }

    public override void OnReConnect()
    {

    }

    public override void OnUpdate(float deltaTime)
    {

    }

    protected override void OnInit()
    {

    }
}
