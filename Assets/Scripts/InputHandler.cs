using UnityEngine;

public class InputHandler
{
    private Invoker invoker;

    public InputHandler(Invoker invoker)
    {
        this.invoker = invoker;
    }

    public void HandleInput(bool isGrounded)
    {
        float move = Input.GetAxis("Vertical");
        float rotate = Input.GetAxis("Horizontal");

        if (move != 0)
        {
            invoker.ExecuteMove(move);
        }

        if (rotate != 0)
        {
            invoker.ExecuteRotate(rotate);
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            invoker.ExecuteJump();
        }
    }
}