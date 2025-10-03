using JetBrains.Annotations;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    private void FixedUpdate()
    {
        //physics code here
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

    }
    void Update()
    {
        //input code here

        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

    }
}
