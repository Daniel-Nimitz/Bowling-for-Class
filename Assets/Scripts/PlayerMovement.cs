using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{

 
    public Vector3 RotationSpeed;

    [SerializeField] float _cubeSpeed;
    [SerializeField] float _normalSpeed;
    [SerializeField] float _sprintSpeed;
    [SerializeField] Rigidbody _cubeRB;
    [SerializeField] float _jumpForce;

    private void Awake()
    {
        _cubeRB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Jump
        if (Input.GetKeyDown(KeyCode.Space)) {
            _cubeRB.AddForce(transform.up * _jumpForce* Time.deltaTime);
        
        }


        //Move Forward and Bakc
        if (Input.GetKey(KeyCode.LeftShift)){
            _cubeSpeed = _sprintSpeed;
        }

        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            _sprintSpeed = _normalSpeed;
        }

        MovePlayer();

    }

    private void MovePlayer()
    {
        _cubeRB.AddForce(transform.right * Input.GetAxis("Horizontal") * Time.deltaTime * _cubeSpeed);
        _cubeRB.AddForce(transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * _cubeSpeed);
        Debug.Log("PlayerMovement is being called");
    }
}