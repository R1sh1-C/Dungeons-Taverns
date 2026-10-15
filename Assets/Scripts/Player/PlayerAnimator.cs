using UnityEngine;

public class PlayerAnimator : CharacterAnimator
{
    private PlayerAttack attack;
    private void Awake()
    {
        base.Awake();

        movement = GetComponent<PlayerMovement>();
        attack = GetComponent<PlayerAttack>();
    }
    public void PlayAttack()
    {
        animator.SetTrigger("Attack");
    }
    public void ComboStart(bool comboState)
    {
        animator.SetBool("ComboQueued", comboState);
    }
}