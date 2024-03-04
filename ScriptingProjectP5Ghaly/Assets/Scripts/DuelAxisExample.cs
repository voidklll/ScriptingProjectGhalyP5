using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuelAxisExample : MonoBehaviour
{
  
    public float hRange;
    public float vRange;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * vRange;

        transform.position = new Vector3(xPos, 0);
    }
}
