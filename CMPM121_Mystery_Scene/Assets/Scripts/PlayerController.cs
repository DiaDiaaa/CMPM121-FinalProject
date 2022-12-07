using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController cc;

    public float moveSpeed;

    public float jumpSpeed;

    private float horizontalMove, verticalMove;

    private Vector3 dir;

    [SerializeField] private float _gravity = -9.81f;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private float _groundDistance = 0.4f;
    [SerializeField] private LayerMask _groundMask;
    
    private Vector3 _velocity;
    private bool _isGrounded;

    private void Start(){
        cc= GetComponent<CharacterController>();
    }

    private void Update()
    {
        _isGrounded = Physics.CheckSphere(_groundCheck.position, _groundDistance, _groundMask);
        if (_isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }
        
        horizontalMove = Input.GetAxis ("Horizontal") * moveSpeed;
        verticalMove = Input.GetAxis ("Vertical")* moveSpeed;

        dir = transform.forward * verticalMove + transform.right * horizontalMove;
        cc.Move(dir*Time.deltaTime);

        _velocity.y += _gravity * Time.deltaTime;
        cc.Move(_velocity * Time.deltaTime);

    }

}
