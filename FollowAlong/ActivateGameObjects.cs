using UnityEngine;
using System.Collections;

public class ActiveObjects : MonoBehaviour
{
    //Active Objects
    void Start()
    {
        gameObject.SetActive(false);

    }
}

public class CheckState : MonoBehaviour
{
    public GameObject myObject;

    void Start()
    {
        Debug.Log("Activate Self: " + myObject.activateSelf);
        Debug.Log("Activate in Hierarchy: " + myObject.activateInHierarchy);
    }
}
