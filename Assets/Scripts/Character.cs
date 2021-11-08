using UnityEngine;

[RequireComponent (typeof(Rigidbody)) ]
public class Character : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;
    [SerializeField]
    private float JumpForce = 300f;

    private bool isGrounded;
    private new Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Movement();
        Jump();
    }

    private void Movement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rigidbody.AddForce(movement * speed);
    }

    private void Jump()
    {
        if (Input.GetAxis("Jump") > 0 && isGrounded)
        {
            rigidbody.AddForce(Vector3.up * JumpForce);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        IsGroundedUpate(collision, true);
    }

    private void OnCollisionExit(Collision collision)
    {
        IsGroundedUpate(collision, false);
    }

    private void IsGroundedUpate(Collision collision, bool value)
    {
        if (collision.gameObject.tag == ("ground"))
        {
            isGrounded = value;
        }
    }
}
