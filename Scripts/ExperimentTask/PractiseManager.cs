using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 练习模式控制
/// </summary>
public class PractiseManager : QSingleton<PractiseManager>
{
    /// <summary>
    /// 表中读取到的任务步骤信息字典
    /// </summary>
    public Dictionary<int, List<TaskTableInfo>> ExperimentTaskDic { get; private set; } = new Dictionary<int, List<TaskTableInfo>>();
    /// <summary>
    /// 是否是练习模式
    /// </summary>
    private bool mIsInPractiseMode = false;
    private int mSoundId = -1;

    public PractiseTaskInfo PraticeStepInfo { get; private set; } = null;
    public Dictionary<int, string> PraticeGroupPair { get; private set; } = null;

    /// <summary>
    /// 进入练习
    /// </summary>
    /// <param name="expId"></param>
    public void EnterPratice(int expId)
    {
        // 判断没有退出的话先退出
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
    /// 退出当前练习任务
    /// </summary>
    public void LeavePratice()
    {
       
    }
    /// <summary>
    /// 接受消息后的回调函数
    /// </summary>
    void OnTaskStep(int eventTypeId, TaskEventArgs e)
    {

    }
    public void LoadCurExperimentTask(int expId)
    {
        if (!ExperimentTaskDic.ContainsKey(expId)) return;
        // 读取一个任务表的所有信息
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
