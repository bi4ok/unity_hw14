using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallContoller : MonoBehaviour
{
    private Animator wallUpDownAnimation;

    private void Awake()
    {
        wallUpDownAnimation = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        wallUpDownAnimation.SetBool("Alive", true);
    }

    private void OnTriggerExit(Collider other)
    {
        wallUpDownAnimation.SetBool("Alive", false);
    }


}
