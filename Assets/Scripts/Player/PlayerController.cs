using System;
using Player.Inputs;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private FloatVariable horizontalInput;
        [SerializeField] private TriggerChannel jumpInput;
        [SerializeField] private float decelerationSpeed;
        [SerializeField] private LayerMask groundLayer;
        [SerializeField] private Transform groundCheck;
        [SerializeField] private float maxMoveSpeed;
        [SerializeField] private float moveSpeed;
        [SerializeField] private float jumpPower;

        private Rigidbody2D _rigidbody;
        private float _jumpTime;

        private const float DecelerationThreshold = 0.95f;
        private const float JumpInputInterval = 0.25f;
        private const float Height = 0.125f;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            jumpInput.OnTriggered += Jump;
        }

        private void OnDestroy()
        {
            jumpInput.OnTriggered -= Jump;
        }

        private void Update()
        {
            Move();
        }

        private void Jump()
        {
            if (_jumpTime + JumpInputInterval > Time.time)
            {
                return;
            }

            if (!Physics2D.Raycast(groundCheck.position, Vector2.down, Height, groundLayer))
            {
                return;
            }
            
            _rigidbody.AddForce(Vector2.up * jumpPower);
            _jumpTime = Time.time;
        }

        private void Move()
        {
            _rigidbody.velocity = Normalize( Vector2.right * (horizontalInput.Value * moveSpeed) + _rigidbody.velocity);
        }

        private Vector2 Normalize(Vector2 velocity)
        {
            if (Mathf.Abs(horizontalInput.Value) < DecelerationThreshold)
            {
                velocity.x = Mathf.Lerp(velocity.x, 0f, Time.deltaTime * decelerationSpeed);
            }
            
            if (velocity.x > maxMoveSpeed)
            {
                velocity.x = maxMoveSpeed;
            }

            if (velocity.x < -maxMoveSpeed)
            {
                velocity.x = -maxMoveSpeed;
            }

            return velocity;
        }
    }
}
