using UnityEngine;

public class PlayerController : Character
{
    private InputSystem_Actions controls;
    private PlayerMovement movement;
    private PlayerAttack attack;

    protected override void Awake()
    {
        base.Awake();

        controls = new InputSystem_Actions();
        movement = GetComponent<PlayerMovement>();
        attack = GetComponent<PlayerAttack>();
    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }

    private void Update()
    {
        Vector2 moveInput = controls.Player.Move.ReadValue<Vector2>();
        movement.SetMovement(moveInput);
        if (controls.Player.Attack.WasPressedThisFrame())
        {
            attack.Attack();
        }

    }
}