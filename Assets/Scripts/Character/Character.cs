using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] protected float maxHealth;
    [SerializeField] protected float movementSpeed;

    protected float currentHealth;
    protected Rigidbody2D rb;

    protected virtual void Awake()
    {
        currentHealth = maxHealth;
        rb = GetComponent<Rigidbody2D>();
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
    public Rigidbody2D Rb
    {
        get => rb;
        set => rb = value;
    }
}
