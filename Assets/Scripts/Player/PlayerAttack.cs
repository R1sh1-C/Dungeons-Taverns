using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private bool isAttacking = false;
    [SerializeField] private AttackData[] attackDatas;
    [SerializeField] private AttackHitbox attackHitbox;
    private AttackData currentData;
    private PlayerAnimator animator;
    private bool comboQueued = false;

    public bool IsAttacking => isAttacking;
    private void Awake()
    {
        animator = GetComponent<PlayerAnimator>();
    }
    public void SetCurrentAttack(int i)
    {
        currentData = attackDatas[i];
        attackHitbox.Damage = currentData.Damage;
    }
    public void Attack()
    {
        if (!isAttacking)
        {
            isAttacking = true;
            animator.PlayAttack();
        }
        else if (isAttacking)
        {
            comboQueued = true;
            animator.ComboStart(comboQueued);
        }
    }
    public void AttackEnd()
    {
        isAttacking = false;
    }
    public void ComboEnd()
    {
        comboQueued = false;
        animator.ComboStart(comboQueued);
    }
}
