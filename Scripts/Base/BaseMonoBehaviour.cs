using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// »ù´¡MonoÀà
/// </summary>
public class BaseMonoBehaviour : MonoBehaviour
{
    private void Awake()
    {
        OnAwake();
    }
    private void Start()
    {
        OnStart();
    }
    private void Update()
    {
        OnUpdate();
    }
    private void FixedUpdate()
    {
        OnFixedUpdate();
    }
    private void LateUpdate()
    {
        OnLateUpdate();
    }
    public virtual void OnAwake()
    {

    }
    public virtual void OnStart()
    {

    }
    public virtual void OnUpdate()
    {

    }
    public virtual void OnFixedUpdate()
    {

    }
    public virtual void OnLateUpdate()
    {

    }
    public virtual void OnReset()
    {

    }
}
