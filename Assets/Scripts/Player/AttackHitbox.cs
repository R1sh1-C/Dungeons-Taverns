using UnityEngine;

public class AttackHitbox : MonoBehaviour
{
    private float damage;
    public float Damage
    {
        get => damage;
        set
        {
            damage = value;
        }
    }
    public  void AttackActivate()
    {
        enabled = true;
    }
    public void AttackDeactivate()
    {
        enabled = false;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            if (collision.TryGetComponent<Character>(out Character character))
            {
                Vector2 hitDirection =
                    (character.transform.position - transform.position).normalized;

                character.TakeDamage(damage, hitDirection);
            }
        }
    }
}
