using UnityEngine;

public class MushkinAnimator : CharacterAnimator
{
    private void Awake()
    {
        base.Awake();

        movement = GetComponent<MushkinMovement>();
    }
}
