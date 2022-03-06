using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Transform player;
        private Vector3 _playerPosition;

        private Vector3 _offset;

        private void Start()
        {
            _offset = transform.position - player.position;
        }

        private void FixedUpdate()
        {
            _playerPosition = new Vector3(0.0f, Input.GetAxis(PlayerInputs.HORIZONTAL_AXIS), 0.0f);
            transform.position = player.position + _offset;
            transform.RotateAround(player.position, _playerPosition, 40 * Time.deltaTime);
            _offset = transform.position - player.position;

            Debug.Log(_playerPosition);
            Debug.Log(transform.rotation);
        }

        public void CameraRotation()
        {
            Debug.Log(transform.rotation.eulerAngles);
        }
    }
}

