using UnityEngine;

public class MeleeEnemyAI : EnemyAI
{
    [SerializeField] float followDistance;
    private EnemyMovement movement;
    private Enemy enemy;
    protected override void Awake()
    {
        base.Awake();
        movement = GetComponent<EnemyMovement>();
    }
    private void Update()
    {
        float playerDistance = Vector2.Distance(transform.position, player.transform.position);
        if(playerDistance <= followDistance)
        {
            Vector2 directionToMove = (player.transform.position - transform.position).normalized;
            movement.Move(directionToMove);
        }

    }
}
