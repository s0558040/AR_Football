using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
// Schwer inspiriter code
/**
 * @author Stefan Manthey
 * Script to hold a button in uGUI
 * Event will be invoked, as long as the button is pushed
 * Script is heavily inspired by Unity3dCollege
 * Source: https://unity3d.college/2018/01/30/unity3d-ugui-hold-click-buttons/
 */
public class LongClickButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool pointerDown;
    public UnityEvent onLongClick;

    public void OnPointerDown(PointerEventData eventData)
    {
        pointerDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pointerDown = false;
    }

    private void Update()
    {
        if (pointerDown && onLongClick != null)
        {
            onLongClick.Invoke();
        }
    }
}
