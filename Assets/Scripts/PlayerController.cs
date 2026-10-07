using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    private InputSystem_Actions controls;
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
    }
}
