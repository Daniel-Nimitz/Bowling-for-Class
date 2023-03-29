using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] public Transform playerPosition;
    [SerializeField] Vector3 offSet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerPosition == null) {

            
            transform.position = playerPosition.position + offSet;

            transform.LookAt(playerPosition);
            return;
        }



        
    }
}
