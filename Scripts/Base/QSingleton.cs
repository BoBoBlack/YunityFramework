using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class MgrBase
{
    protected static List<MgrBase> s_MgrList = new List<MgrBase>();

    public static void ReConnectAll()
    {
        for (int i = 0; i < s_MgrList.Count; i++)
        {
            if (s_MgrList[i] == null)
            {
                continue;
            }

            s_MgrList[i].OnReConnect();
        }
    }

    public static void ClearAll()
    {
        for (int i = 0; i < s_MgrList.Count; i++)
        {
            if (s_MgrList[i] == null)
            {
                continue;
            }

            s_MgrList[i].Clear();
        }
    }

    public static void UpdateAll(float deltaTime)
    {
        for (int i = 0; i < s_MgrList.Count; i++)
        {
            if (s_MgrList[i] == null)
            {
                continue;
            }

            s_MgrList[i].OnUpdate(deltaTime);
        }
    }

    protected abstract void OnInit();

    public abstract void OnUpdate(float deltaTime);

    public abstract void OnReConnect();

    public abstract void Clear();
}
public abstract class QSingleton<T> : MgrBase where T : QSingleton<T>, new()
{
    protected static T mInstance = null;

    public static T GetInstance()
    {
        if (null == mInstance)
        {
            mInstance = new T();
            mInstance.OnInit();

            s_MgrList.Add(mInstance);
        }
        return mInstance;
    }

    public static T instance => GetInstance();

    public void Dispose()
    {
        mInstance = null;
    }
}
