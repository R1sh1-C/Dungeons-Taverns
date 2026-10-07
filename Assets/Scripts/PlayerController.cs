using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    private InputSystem_Actions controls;
    private Animator animator;
    private Vector2 moveDirection;
    private void Awake()
    {
        controls = new InputSystem_Actions();
    }
    private void OnEnable()
    {
        controls.Player.Enable();
    }
    private void OnDisable()
    {
        controls.Player.Disable();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        Vector3 movement = controls.Player.Move.ReadValue<Vector2>();
        transform.position += (movement * (movementSpeed * 0.001f));
        moveDirection = new Vector2(movement.x, movement.y).normalized;
        Anim();
    }
    private void Anim()
    {
        animator.SetFloat("xMovement", moveDirection.x);
        animator.SetFloat("yMovement", moveDirection.y);
        animator.SetFloat("movementMagnitude", moveDirection.magnitude);
    }
}
