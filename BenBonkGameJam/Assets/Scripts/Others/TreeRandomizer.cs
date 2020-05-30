using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            children.transform.eulerAngles = angles[i];
            i++;
        }
    }
}
