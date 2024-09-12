using UnityEngine;

public class InputHandler
{
    private Invoker invoker;

    public InputHandler(Invoker invoker)
    {
        this.invoker = invoker;
    }

    public void HandleInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            invoker.ExecuteMove(1f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            invoker.ExecuteMove(-1f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            invoker.ExecuteRotate(-1f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            invoker.ExecuteRotate(1f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            invoker.ExecuteJump();
        }
    }
}