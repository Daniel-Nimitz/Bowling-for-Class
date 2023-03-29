using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundTarget: MonoBehaviour
{
    [SerializeField] Vector3 _rotationSpeed;



    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotationSpeed);
    }
}
