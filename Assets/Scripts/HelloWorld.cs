using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public Transform _thisObjectTransform;


    
    void Start()
    {
        Debug.Log("The actual position is " + transform.position);
        Debug.Log("To double check the position is: " + _thisObjectTransform.position);
    }

    void Update()
    {

        _thisObjectTransform.Translate(0, 0, -1);
    }
}