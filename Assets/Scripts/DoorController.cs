using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator doorAnimation;
    private float currentTimer;
    private bool currentState;

    private void Awake()
    {
        doorAnimation = GetComponent<Animator>();
        currentTimer = 0;
    }

    private void Update()
    {
        DoorTick();
    }

    private void DoorTick()
    {
        currentTimer += Time.deltaTime;
        doorAnimation.SetFloat("DoorTimer", currentTimer);
    }

    private void DoorChangeState()
    {
        currentTimer = 0;
        doorAnimation.SetFloat("DoorTimer", currentTimer);
        currentState = doorAnimation.GetBool("Open") ? false : true;
        doorAnimation.SetBool("Open", currentState);
    }

}
