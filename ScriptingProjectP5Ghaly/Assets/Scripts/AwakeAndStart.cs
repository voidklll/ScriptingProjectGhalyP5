using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    public void Awake()
    {
        Debug.Log("Awake called.");
    }
    void Start()
    {
        Debug.Log("Start called.");
    }
}
