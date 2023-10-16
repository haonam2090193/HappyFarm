using UnityEngine;

public class Movement : MonoBehaviour
{
    [Tooltip("Speed of the movement")]
    public float speed = 5f;

    private Rigidbody2D rb;
    private Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.velocity = movement * speed;

        animator.SetFloat("X", moveHorizontal);
        animator.SetFloat("Y", moveVertical);
    }
}