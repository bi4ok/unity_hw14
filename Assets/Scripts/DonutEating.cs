using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutEating : MonoBehaviour
{
    [SerializeField] private GameObject _particles;

    private void Awake()
    {
        _particles.SetActive(false);
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        _particles.SetActive(true);
        yield return new WaitUntil(IsActive);
        gameObject.SetActive(false);
    }

    private bool IsActive()
    {
        return _particles ? false : true;
    }
}
