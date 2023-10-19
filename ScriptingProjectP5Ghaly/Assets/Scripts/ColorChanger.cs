using System.Collections;
using System.Collections.Generic;
using UnityEditor.Profiling;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyUp(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
       if (Input.GetKeyUp(KeyCode.G))
        {
         GetComponent<Renderer>().material.color = Color.green;   
        }
       if(Input.GetKeyUp(KeyCode.B))
        {
         GetComponent<Renderer>().material.color= Color.blue;
        }
    }
}
