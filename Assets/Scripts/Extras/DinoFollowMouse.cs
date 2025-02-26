using UnityEngine;

public class DinoFollowMouse : MonoBehaviour
{
    public float walkSpeed = 5f;
    public float maxSpeed = 5f;

    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float targetX = mousePosition.x;
        float direction = targetX - transform.position.x;

        float newVelocityX = direction * walkSpeed;

        newVelocityX = Mathf.Clamp(newVelocityX, -maxSpeed, maxSpeed);

        _rigidbody2D.velocity = new Vector2(newVelocityX, _rigidbody2D.velocity.y);
    }
}
