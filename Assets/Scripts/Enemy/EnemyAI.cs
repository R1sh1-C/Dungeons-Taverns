using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    protected GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
}
