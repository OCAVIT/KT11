using UnityEngine;

public class PlayerMovement
{
    private Rigidbody rb;
    private float moveSpeed;
    private float rotationSpeed;
    private float jumpForce;

    public PlayerMovement(Rigidbody rb, float moveSpeed, float rotationSpeed, float jumpForce)
    {
        this.rb = rb;
        this.moveSpeed = moveSpeed;
        this.rotationSpeed = rotationSpeed;
        this.jumpForce = jumpForce;
    }

    public void Move(float move)
    {
        Vector3 moveDirection = rb.transform.forward * move;
        rb.MovePosition(rb.position + moveDirection);
    }

    public void Rotate(float rotate)
    {
        Quaternion turn = Quaternion.Euler(0f, rotate, 0f);
        rb.MoveRotation(rb.rotation * turn);
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}