using UnityEngine;

public class MeleeEnemyAI : EnemyAI
{
    private EnemyMovement movement;
    protected override void Awake()
    {
        base.Awake();
        movement = GetComponent<EnemyMovement>();
        Debug.Log("1");
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 directionToMove = (player.transform.position - transform.position).normalized;
        movement.Move(directionToMove);
        Debug.Log("2");
    }
}
