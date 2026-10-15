using UnityEngine;

public class MushkinAI : EnemyAI
{
    [SerializeField] float followDistance;
    private MushkinMovement movement;
    private Enemy enemy;
    protected override void Awake()
    {
        base.Awake();
        movement = GetComponent<MushkinMovement>();
    }
    private void Update()
    {
        float playerDistance = Vector2.Distance(transform.position, player.transform.position);
        if (playerDistance <= followDistance)
        {
            Vector2 directionToMove = (player.transform.position - transform.position).normalized;
            movement.Move(directionToMove);
            movement.SetMovement(directionToMove);
        }
        else
        {
            movement.SetMovement(Vector2.zero);
        }
        
    }
}
