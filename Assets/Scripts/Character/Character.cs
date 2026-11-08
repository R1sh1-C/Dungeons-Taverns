using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] protected float maxHealth;
    [SerializeField] protected float movementSpeed;
    [SerializeField] private CharacterDamageReaction damageReaction;

    protected float currentHealth;
    protected Rigidbody2D rb;
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

    protected virtual void Awake()
    {
        currentHealth = maxHealth;
        rb = GetComponent<Rigidbody2D>();
        damageReaction = GetComponent<CharacterDamageReaction>();
    }
    public virtual void TakeDamage(float damage, Vector2 hitDirection)
    {
        currentHealth -= damage;

        damageReaction.PlayReaction(hitDirection);
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    protected virtual void Die()
    {
        Destroy(gameObject);
    }
}
