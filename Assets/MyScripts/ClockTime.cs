using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockTime : MonoBehaviour
{
    [SerializeField] private Transform _hours;
    [SerializeField] private Transform _minutes;
    [SerializeField] private Transform _seconds;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _secondTickSound;

    private int previousSecond;
    void Update()
    {
        setHours();
        setMinutes();
        setSeconds();
    }

    void setHours()
    {
        //Take hours value and convert in range(0, 1), push this value in lerp and convert to angle in range(0, 360)
        _hours.localEulerAngles = new Vector3(Mathf.Lerp(0, 360, Mathf.InverseLerp(0, 12, DateTime.Now.Hour % 12) ), 0, 0);
    }
    
    void setMinutes()
    {
        _minutes.localEulerAngles = new Vector3(Mathf.Lerp(0, 360, Mathf.InverseLerp(0, 60, DateTime.Now.Minute)), 0, 0);
    }
    
    void setSeconds()
    {
        _seconds.localEulerAngles = new Vector3(Mathf.Lerp(0, 360, Mathf.InverseLerp(0, 60, DateTime.Now.Second)), 0, 0);
        
        if (DateTime.Now.Second != previousSecond) // Sound tick every second change
            _audioSource.PlayOneShot(_secondTickSound);

        previousSecond = DateTime.Now.Second;
    }
}
