using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFallControl : MonoBehaviour
{
    private Animator _cubeAnimator;
    private float _currentTimer;
    void Start()
    {
        _cubeAnimator = GetComponent<Animator>();
        _currentTimer = 0;
        _cubeAnimator.SetFloat("Timer", _currentTimer);
    }

    private void FixedUpdate()
    {
        _currentTimer += Time.deltaTime;
        _cubeAnimator.SetFloat("Timer", _currentTimer);
    }

    public void StateChanger()
    {
        _currentTimer = 0;
        _cubeAnimator.SetFloat("Timer", _currentTimer);
        bool newState = !_cubeAnimator.GetBool("IsUp");
        _cubeAnimator.SetBool("IsUp", newState);
    }
}
