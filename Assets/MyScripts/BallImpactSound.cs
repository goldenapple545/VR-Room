using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallIpmactSound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip;
    [SerializeField] private Rigidbody _rigidbody;
    
    private void OnCollisionEnter(Collision collision)
    {
        _audioSource.volume = Mathf.InverseLerp(0, 10,_rigidbody.velocity.magnitude);
        _audioSource.PlayOneShot(_audioClip);
    }
}
