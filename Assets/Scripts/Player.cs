using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 720f;
    public float jumpForce = 5f;

    private Rigidbody rb;
    private bool isGrounded;
    private bool inputEnabled = true;

    private PlayerMovement playerMovement;
    private Invoker invoker;
    private InputHandler inputHandler;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerMovement = new PlayerMovement(rb, moveSpeed, rotationSpeed, jumpForce);
        invoker = new Invoker(playerMovement);
        inputHandler = new InputHandler(invoker);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            inputEnabled = !inputEnabled;
            Debug.Log("Input status changed: " + (inputEnabled ? "Enabled" : "Disabled"));
        }

        if (inputEnabled)
        {
            inputHandler.HandleInput(isGrounded);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnApplicationFocus(bool hasFocus)
    {
        if (hasFocus)
        {
            inputEnabled = true;
            Debug.Log("Input enabled due to focus");
        }
    }
}