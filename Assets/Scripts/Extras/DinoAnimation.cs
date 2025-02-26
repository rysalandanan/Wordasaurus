using UnityEngine;

public class DinoAnimation : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    private float _speedThreshold = 0.8f;
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float speed = Mathf.Abs(_rigidbody2D.velocity.x); // Use absolute value to check movement

        if (speed > _speedThreshold)
        {
            _animator.SetInteger("State", 1); // Walking animation
        }
        else
        {
            _animator.SetInteger("State", 0); // Idle animation
        }
    }
}
