using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    [SerializeField] private GameObject plane;
    [SerializeField, Range(0,10)] private float timer=5;
    private Animator _planeAnimation;
    private bool _startTimer;

    private void Awake()
    {
        _planeAnimation = GetComponent<Animator>();
        _startTimer = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        _startTimer = true;
    }

    private void FixedUpdate()
    {
        if (_startTimer)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                _planeAnimation.SetTrigger("FallDown");
            }
        }

    }

    private void PlaneOffAfterDrop()
    {
        plane.SetActive(false);
    }

}
