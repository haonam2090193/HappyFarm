using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private Animator animator;
    Vector2 movement;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("moveX", movement.x);
        animator.SetFloat("moveY", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (Input.GetAxisRaw("Horizontal") == 1|| Input.GetAxisRaw("Horizontal") == -1|| Input.GetAxisRaw("Vertical") == 1|| Input.GetAxisRaw("Vertical") == -1)
        {
            animator.SetFloat("lastX", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("lastY", Input.GetAxisRaw("Vertical"));
        }

    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
    }
}