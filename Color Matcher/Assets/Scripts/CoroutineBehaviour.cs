using System.Collections;
using UnityEngine;

public class CoroutineBehaviour : MonoBehaviour
{
    public bool canRun = true;
    private WaitForSeconds wfsObj;
    private float seconds = 3f;
    IEnumerator Start()
    {
        Debug.Log("Start");
        yield return new WaitForSeconds(3);
        Debug.Log("Late Start");

        while (canRun)
        {
            yield return new WaitForFixedUpdate();
            Debug.Log("Run on Start");
        }
    }
}
