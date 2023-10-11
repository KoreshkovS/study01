using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private Rigidbody _playerRB;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _playerRB.AddForce(transform.up * _force);
        }
    }
}
