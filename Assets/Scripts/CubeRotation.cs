using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private Vector3 _rotation;

    void Update()
    {
        Quaternion deltaRotation = Quaternion.Euler(_rotation * Time.deltaTime);
        _rb.MoveRotation(_rb.rotation * deltaRotation);
    }
}
