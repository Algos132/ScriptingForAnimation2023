using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextLabelBehaviour : MonoBehaviour
{
    public Text label;
    public FloatData dataObj;

    void Start()
    {
        label = GetComponent<Text>();
        label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}

