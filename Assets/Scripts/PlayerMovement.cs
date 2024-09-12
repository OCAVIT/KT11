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

    public void Move(float direction)
    {
        Vector3 movement = rb.transform.forward * direction * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }

    public void Rotate(float direction)
    {
        float turn = direction * rotationSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}