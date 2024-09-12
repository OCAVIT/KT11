public class Invoker
{
    private PlayerMovement playerMovement;

    public Invoker(PlayerMovement playerMovement)
    {
        this.playerMovement = playerMovement;
    }

    public void ExecuteMove(float direction)
    {
        playerMovement.Move(direction);
    }

    public void ExecuteRotate(float direction)
    {
        playerMovement.Rotate(direction);
    }

    public void ExecuteJump()
    {
        playerMovement.Jump();
    }
}