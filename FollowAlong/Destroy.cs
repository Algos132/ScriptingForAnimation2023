using UnityEngine;
using System.Collections;

public class DestroyBasic : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}

public class DestroyOther : MonoBehaviour
{
    public GameObject other;

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(other);
        }
    }
}

public class DestroyComponent
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}