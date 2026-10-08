using UnityEngine;

public class Enemy : Character
{
    [SerializeField] protected float attackDamage;
    private EnemyAI enemyAI;
    private EnemyMovement enemyMovement;
    protected override void Awake()
    {
        base.Awake();
        enemyAI = GetComponent<EnemyAI>();
        enemyMovement = GetComponent<EnemyMovement>();
    }
}

