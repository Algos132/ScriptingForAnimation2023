using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class MouseChanger : MonoBehaviour
{
    public UnityEvent mouseEnterEvent, mouseExitEvent;


    private void OnMouseEnter()
    {
        mouseEnterEvent.Invoke();
    }

    private void OnMouseExit()
    {
        mouseExitEvent.Invoke();
    }
}