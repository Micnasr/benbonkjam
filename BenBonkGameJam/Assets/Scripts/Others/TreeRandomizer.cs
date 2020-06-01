using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TreeRandomizer : MonoBehaviour
{
    [SerializeField]
    private List<Vector3> angles;

    void Start()
    {   
        int i = 0;    
        foreach (GameObject children in GameObject.FindGameObjectsWithTag("WoodBone"))
        {
            if (i >= angles.Count) break;
            if (!children.transform.IsChildOf(transform)) continue;
            i = Random.Range(0, 13);
            children.transform.eulerAngles = angles[i];
            i++;
        }
    }
}
