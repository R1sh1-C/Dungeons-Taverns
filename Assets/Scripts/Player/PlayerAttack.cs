using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackDamage;
    [SerializeField] private float attackSpeed;
    [SerializeField] private bool isAttacking = false;
    private PlayerAnimator animator;

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
        isAttacking = true;
        animator.PlayAttack();
    }
    public void AttackEnd()
    {
        isAttacking = false;
    }
}
