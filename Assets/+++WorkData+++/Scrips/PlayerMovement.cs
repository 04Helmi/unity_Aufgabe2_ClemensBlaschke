using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rigidbody;

    private Vector2 moveDirection;

    // Update is called once per frame
    void Update()
    {
        ProcessImputs();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void ProcessImputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY);
    }

    private void Move()
    {
        rigidbody.linearVelocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
