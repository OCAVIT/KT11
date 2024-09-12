public class MoveCommand : ICommand
{
    private PlayerMovement playerMovement;
    private float direction;

    public MoveCommand(PlayerMovement playerMovement, float direction)
    {
        this.playerMovement = playerMovement;
        this.direction = direction;
    }

    public void Execute()
    {
        playerMovement.Move(direction);
    }
}