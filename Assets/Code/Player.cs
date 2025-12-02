using UnityEngine;

public class Player : MonoBehaviour
{
    private float moveSpeed = 5f;
    private float jumpForce = 10f;

    private Rigidbody2D rd;
    private void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rd.linearVelocity = new Vector2(moveInput * moveSpeed, rd.linearVelocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rd.linearVelocity = new Vector2(rd.linearVelocity.x, jumpForce);
        }
    }
}
