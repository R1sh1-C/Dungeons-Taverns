using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] protected float maxHealth;
    [SerializeField] protected float movementSpeed;

    protected float currentHealth;

    protected virtual void Awake()
    {
        currentHealth = maxHealth;
    }
    protected virtual void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    protected virtual void Die()
    {
        Destroy(gameObject);
    }
    public float MovementSpeed
    {
        get => movementSpeed;
        set => movementSpeed = value;
    }
}
