using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    public int jumpForce = 100;
    public float speed = 0.05f;
    public float jumpCooldownTime = 5f;
    private float nextJumpTime = 0;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        // Left/Right movement - using transform.position (considering changing to add force system??)

        Vector2 position = transform.position;

        if (Input.GetKey(KeyCode.D))
        {

            position.x = position.x + speed;

        }

        if (Input.GetKey(KeyCode.A))
        {

            position.x = position.x - speed;

        }

        transform.position = position;

        // Jumping - using physics system

        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextJumpTime)
        {

            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            nextJumpTime = Time.time + jumpCooldownTime;

        }

    }
}
