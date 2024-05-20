using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logger : MonoBehaviour
{
    public Transform[] objects;

    // Update is called once per frame
    void Update()
    {
        foreach (var obj in objects)
        {
            Debug.Log(obj.name + " - " + obj.position);
        }
    }
}
