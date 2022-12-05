using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

// Control basic character movement
public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Camera _MainCam;
    [SerializeField] private CharacterController Controller;
    [SerializeField] private float _MouseSensitivity = 100f;
    [SerializeField] private float _CharacterMoveSpeed = 10f;
    [SerializeField] private float _Gravity = -9.8f;
    private float _XRotation = 0f;
    private Vector3 _Velocity;
    
    
    

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        // Camera Rotation
        float mouseX = Input.GetAxis("Mouse X") * _MouseSensitivity * Time.deltaTime;   // Get mouse horizontal move speed
        float mouseY = Input.GetAxis("Mouse Y") * _MouseSensitivity * Time.deltaTime;   // Get mouse vertical move speed
        
        _XRotation -= mouseY;
        _XRotation = Mathf.Clamp(_XRotation, -90f, 90f);
        
        _MainCam.transform.localRotation = Quaternion.Euler(_XRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
        
        // Character Movement
        float HorizontalMovement = Input.GetAxis("Horizontal");     // Horizontal move direction
        float VerticalMovement = Input.GetAxis("Vertical");         // Vertical move direction

        Vector3 movement = transform.right * HorizontalMovement + transform.forward * VerticalMovement;
        Controller.Move(movement * Time.deltaTime * _CharacterMoveSpeed);
        
        // Gravtiy
        _Velocity.y += _Gravity * Time.deltaTime;
        Controller.Move(_Velocity * Time.deltaTime);


    }
}
