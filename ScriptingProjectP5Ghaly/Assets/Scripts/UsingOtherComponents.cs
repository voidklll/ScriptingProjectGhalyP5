using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;
    private anotherscript anotherscript;
    private yetanotherscript yetanotherscript;
    private BoxCollider boxCol;
    
    void Awake()
    {
        anotherscript = GetComponent<anotherscript>();
        yetanotherscript = otherGameObject.GetComponent<yetanotherscript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }
    
    void Start()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("The player's score is " + anotherscript.playerScore);
        Debug.Log("The player has died " + yetanotherscript.numberOfPlayerDeaths + " times");
    }
}
