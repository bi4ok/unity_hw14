using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]
public class OpenDoor : MonoBehaviour
{
    private Animator _doorAnimation;
    [SerializeField] GameObject tip;

    private void Awake()
    {
        tip.SetActive(false);
        _doorAnimation = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        tip.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _doorAnimation.SetTrigger("OpenFlag");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        tip.SetActive(false);
    }
}
