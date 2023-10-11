using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _force;
    [SerializeField] private float _jumpForce;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
        _rb.AddForce(Vector3.forward * _force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(Vector3.back * _force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(Vector3.left * _force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(Vector3.right * _force * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector3.up * _jumpForce);
        }
    }
}
