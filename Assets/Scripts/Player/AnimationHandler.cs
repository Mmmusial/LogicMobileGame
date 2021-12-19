using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class AnimationHandler : MonoBehaviour
    {
        [SerializeField] private Animator animator;
        
        private Rigidbody2D _rigidbody;
        
        private static readonly int SpeedHash = Animator.StringToHash("Speed");
        private static readonly int SideHash = Animator.StringToHash("Side");
        private const float VelocityThreshold = 0.5f;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (Mathf.Abs(_rigidbody.velocity.x) > VelocityThreshold)
            {
                animator.SetInteger(SideHash, _rigidbody.velocity.x > 0 ? 1 : 3);
            }
            
            animator.SetFloat(SpeedHash, Mathf.Abs(_rigidbody.velocity.x));
        }
        
    }

}