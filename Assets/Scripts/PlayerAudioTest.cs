using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioTest : MonoBehaviour
{
    [SerializeField] private AudioSource _collisionSound;

    //private void OnCollisionEnter(Collision collision)
    //{
    //    _collisionSound.Play();
    //}
    private void OnTriggerEnter(Collider other)
    {
        _collisionSound.Play();
    }
}
