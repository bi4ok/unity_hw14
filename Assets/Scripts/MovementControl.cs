using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class MovementControl : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float _speed = 2.0f;
        private Rigidbody _playerRigidBody;

        private void Awake()
        {
            _playerRigidBody = GetComponent<Rigidbody>();
        }

        public void MoveHorizontal(Vector3 movementVector)
        {
            
            _playerRigidBody.AddForce(movementVector * _speed);
        }
    }
}

