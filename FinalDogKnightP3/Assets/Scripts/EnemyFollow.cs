using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] float stoppingDistance;

    
    float lastAttackTime = 2;
    float attackCooldown = 3;

    NavMeshAgent agent;

    GameObject target;

    public Animator anim;

    private void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {

        float dist = Vector3.Distance(transform.position, target.transform.position);
        if(dist < stoppingDistance)
        {
            StopEnemy();
            if(Time.time - lastAttackTime >= attackCooldown)
            {
                lastAttackTime = Time.time;
            } 
        }
        else
        {
             GoToTarget();
        }
    }

    private void GoToTarget()
    {
        agent.isStopped = false;
        agent.SetDestination(target.transform.position);
        if(agent.isStopped = false);
        {
            anim.SetTrigger("Walk");
        }
    }

    private void StopEnemy()
    {
        
        agent.isStopped = true;
        if (agent.isStopped = true)
        {
            anim.SetTrigger("Attack");
        }
    }
}
