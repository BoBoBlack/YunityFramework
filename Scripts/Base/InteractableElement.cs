using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
/// <summary>
/// ����������
/// </summary>
public class InteractableElement : BaseElement
{
   
    private void OnMouseEnter()
    {
        OnInteractEnter();
    }
    private void OnMouseOver()
    {
        OnInteractStay();
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0)
        {
            OnInteractScroll(scroll);
        }
    }
    private void OnMouseExit()
    {
        OnInteractExit();
    }
    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
            OnInteractDown_Left();
        if (Input.GetMouseButtonDown(1))
            OnInteractDown_Right();
    }
    private void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
            OnInteractUp_Left();
        if (Input.GetMouseButtonUp(1))
            OnInteractUp_Right();
    }
    private void OnMouseUpAsButton()
    {
        if (Input.GetMouseButtonUp(0))
            OnInteractClick_Left();
        if (Input.GetMouseButtonUp(1))
            OnInteractClick_Right();
    }
    private void OnMouseDrag()
    {
        if (Input.GetMouseButton(0))
            OnInteractDrag_Left();
        if (Input.GetMouseButton(1))
            OnInteractDrag_Right();
    }

    /// <summary>
    /// �������
    /// </summary>
    public virtual void OnInteractEnter() { }
    /// <summary>
    /// ���ͣ��
    /// </summary>
    public virtual void OnInteractStay() { }
    /// <summary>
    /// ����Ƴ�
    /// </summary>
    public virtual void OnInteractExit() { }

    /// <summary>
    /// ��갴��-���
    /// </summary>
    public virtual void OnInteractDown_Left() { }
    /// <summary>
    /// ��갴��-�Ҽ�
    /// </summary>
    public virtual void OnInteractDown_Right() { }

    /// <summary>
    /// ���̧��-���
    /// </summary>
    public virtual void OnInteractUp_Left() { }
    /// <summary>
    /// ���̧��-�Ҽ�
    /// </summary>
    public virtual void OnInteractUp_Right() { }

    /// <summary>
    /// �����-���
    /// </summary>
    public virtual void OnInteractClick_Left() { }
    /// <summary>
    /// �����-�Ҽ�
    /// </summary>
    public virtual void OnInteractClick_Right() { }

    /// <summary>
    /// �����ק-���
    /// </summary>
    public virtual void OnInteractDrag_Left() { }
    /// <summary>
    /// �����ק-�Ҽ�
    /// </summary>
    public virtual void OnInteractDrag_Right() { }

    /// <summary>
    /// �����ֻ���
    /// </summary>
    /// <param name="scroll"></param>
    public virtual void OnInteractScroll(float scroll) { }
}
