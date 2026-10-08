using UnityEngine;

public class PlayerController : Character
{
    private InputSystem_Actions controls;
    private Animator animator;
    private Vector2 moveDirection;
    private Vector2 faceDirection;
    private void Awake()
    {
        base.Awake();
        controls = new InputSystem_Actions();
        animator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        controls.Player.Enable();
    }
    private void OnDisable()
    {
        controls.Player.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        Move();
        Anim();
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDirection * movementSpeed * Time.fixedDeltaTime);
    }
    private void Move()
    {
        Vector2 movement = controls.Player.Move.ReadValue<Vector2>();
        moveDirection = movement.normalized;
        if(moveDirection != Vector2.zero)
        {
            faceDirection = moveDirection;
        }
    }
    private void Anim()
    {
        animator.SetFloat("xMovement", moveDirection.x);
        animator.SetFloat("yMovement", moveDirection.y);
        animator.SetFloat("movementMagnitude", moveDirection.magnitude);
        animator.SetFloat("xFace", faceDirection.x);
        animator.SetFloat("yFace", faceDirection.y);
    }
}
