using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(MovementControl))]
    public class PlayerControl : MonoBehaviour
    {
        [SerializeField] private GameObject _cameraObject;
        private Vector3 _playerPosition;
        private MovementControl _playerMove;
        private Animator _playerAnimation;
        private Rigidbody _playerBody;
        private Transform _playerVisual;
        private Transform _playerParticles;

        private void Awake()
        {
            _playerMove = GetComponent<MovementControl>();
            _playerAnimation = GetComponent<Animator>();
            _playerBody = GetComponent<Rigidbody>();
            _playerVisual = transform.GetChild(0);
            _playerParticles = transform.GetChild(1);
            _playerParticles.gameObject.SetActive(false);
        }

        private void Update()
        {
            //_playerPosition = new Vector3(-Input.GetAxis(PlayerInputs.HORIZONTAL_AXIS), 0.0f, -Input.GetAxis(PlayerInputs.VERTICAL_AXIS));
            var input = Vector2.zero;
            input.x = Input.GetAxis("Vertical");
            input.y = Input.GetAxis("Horizontal");
            input = Vector2.ClampMagnitude(input, 1f);
            var forward = Vector3.ProjectOnPlane(_cameraObject.transform.forward, Vector3.up);
            var right = Vector3.ProjectOnPlane(_cameraObject.transform.right, Vector3.up);
            _playerPosition = forward.normalized * input.x + right.normalized * input.y;
            _playerAnimation.SetFloat("Velocity", _playerBody.velocity.magnitude);

        }

        private void FixedUpdate()
        {
            _playerMove.MoveHorizontal(_playerPosition);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("DeathTrap"))
            {
                _playerVisual.gameObject.SetActive(false);
                _playerParticles.gameObject.SetActive(true);

            }
        }


    }

}
