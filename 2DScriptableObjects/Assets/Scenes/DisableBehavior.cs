using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DisableBehavior : MonoBehaviour
{
    public UnityEvent disabled, IsEnabled;

    private void OnDisable()
    {
        disabled.Invoke();
    }

    private void OnEnable()
    {
        IsEnabled.Invoke(); 
    }
}
