using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    private PlayerMovement playerMovement;
    private InputHandler inputHandler;
    private Invoker invoker;

    public float moveSpeed;
    public float rotationSpeed;
    public float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerMovement = new PlayerMovement(rb, moveSpeed, rotationSpeed, jumpForce);
        invoker = new Invoker(playerMovement);
        inputHandler = new InputHandler(invoker);
    }

    void Update()
    {
        inputHandler.HandleInput();
    }
}