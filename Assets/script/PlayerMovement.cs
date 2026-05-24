using UnityEngine;



public class PlayerMovement : MonoBehaviour
{

    private Animator anim;
    
    public float speed = 5f;

    private Rigidbody2D rb;

    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement.Normalize();

        anim.SetFloat("MoveX", movement.x);
        anim.SetFloat("MoveY", movement.y);

        anim.SetBool("IsMoving", movement != Vector2.zero); 
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement * speed;
    }
}
