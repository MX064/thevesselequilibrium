using UnityEngine;

public class shadermove2 : MonoBehaviour
{
    private float moveSpeed = 1.3f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 moveDirection = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );

        Vector2 newPosition = rb.position + moveDirection.normalized * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(newPosition);
    }
}
