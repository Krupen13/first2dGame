using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 moveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right Arrow
        moveDirection.y = Input.GetAxisRaw("Vertical"); // W/S or Up/Down Arrow
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
    }
}
