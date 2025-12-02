using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 5f;
    [SerializeField]private float jumpForce = 10f;
    [field: SerializeField]private bool IsInvulnerable = false;
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
    public void SetMoveSpeed(float NewSpeed)
    {
        moveSpeed *= NewSpeed;
    }
    public void SetInvulnerabilty(bool IsEnabled)
    {
        IsEnabled = true;
        IsInvulnerable = IsEnabled;
    }
    
}
