using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;

    private int num;
    public void CreateInstance ()
        {
        Instantiate(prefab);
        }

    public void CreateInstance(Vector3Data  obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList(Vector3DataList obj)
    {
        for (int i = 0; i < obj.vector3List.Count; i++)
        {
            Instantiate(prefab, obj.vector3List[i].value, Quaternion.identity);
        }
    }


    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        num++;
        Instantiate(prefab, obj.vector3List[num].value, Quaternion.identity);
        if (num == obj.vector3List.Count)
        {
            num = 0;
        }
    }
}
