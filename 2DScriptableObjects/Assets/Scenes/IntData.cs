using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    [SerializeField] int value;

    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }
}
