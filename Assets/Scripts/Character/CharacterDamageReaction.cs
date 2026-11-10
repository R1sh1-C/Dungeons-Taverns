using System.Collections;
using UnityEngine;

public class CharacterDamageReaction : MonoBehaviour
{
    [Header("Knockback")]
    [SerializeField] private CharacterMovement movement;
    [SerializeField] private float knockbackStrength;
    [Header("Visual")]
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Color hitColor = Color.red;
    [SerializeField] private float colorDuration = 0.15f;

    private Color originalColor;
    private Coroutine colorCoroutine;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        movement = GetComponent<CharacterMovement>();
        originalColor = spriteRenderer.color;
    }

    public void PlayReaction(Vector2 hitDirection)
    {
        movement.ApplyKnockback(hitDirection, knockbackStrength);

        if (colorCoroutine != null)
            StopCoroutine(colorCoroutine);

        colorCoroutine = StartCoroutine(ChangeColor());
    }

    private IEnumerator ChangeColor()
    {
        spriteRenderer.color = hitColor;

        yield return new WaitForSeconds(colorDuration);

        spriteRenderer.color = originalColor;

        colorCoroutine = null;
    }
}