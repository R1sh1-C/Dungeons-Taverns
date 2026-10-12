using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackDamage;
    [SerializeField] private float attackSpeed;
    [SerializeField] private bool isAttacking = false;
    private PlayerAnimator animator;
    private bool comboQueued = false;

    public bool IsAttacking => isAttacking;
    private void Awake()
    {
        animator = GetComponent<PlayerAnimator>();
    }
    // Update is called once per frame
    void Update()
    {

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
