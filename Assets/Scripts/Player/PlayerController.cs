using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public PlayerInput playerInput;
    public Vector2 direction;
    public float movementSpeed;
    public Rigidbody2D rb;

    private InputAction moveAction;

    private void Awake()
    {
        moveAction = playerInput.actions["Move"];
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    private void Update()
    {
        direction = moveAction.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Time.fixedDeltaTime * movementSpeed * direction);
    }

}
