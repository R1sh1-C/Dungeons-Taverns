using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    private InputSystem_Actions controls;
    private Animator animator;
    private Vector2 moveDirection;
    private Vector2 faceDirection;
    private void Awake()
    {
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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Anim();
    }
    private void Move()
    {
        Vector2 movement = controls.Player.Move.ReadValue<Vector2>();
        transform.position += (Vector3)(movement * movementSpeed * Time.deltaTime);
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
