using UnityEngine;

[CreateAssetMenu(fileName = "NewAttackData", menuName = "Combat/Attack Data")]
public class AttackData : ScriptableObject
{
    [Header("Attack Properties")]
    [SerializeField] private float damage;
    [SerializeField] private float attackSpeed;

    [Header("Animation")]
    [SerializeField] private string animationName;

    [Header("Animations")]
    [SerializeField] private AnimationClip leftAnimation;
    [SerializeField] private AnimationClip rightAnimation;

    public float Damage => damage;
    public float AttackSpeed => attackSpeed;
    public string AnimationName => animationName;
    public AnimationClip LeftAnimation => leftAnimation;
    public AnimationClip RightAnimation => rightAnimation;
}