using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform target; 
    private NavMeshAgent agent;

    public float updateInterval = 0.5f;
    private float timer = 0f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (target == null)
        {
            Debug.LogError("Цель не назначена!");
        }
    }

    void Update()
    {
        if (target != null)
        {
            timer += Time.deltaTime;
            if (timer >= updateInterval)
            {
                agent.SetDestination(target.position);
                timer = 0f;
            }
        }
    }
}
