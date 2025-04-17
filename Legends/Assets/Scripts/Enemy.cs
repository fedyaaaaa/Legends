using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform target;
    private NavMeshAgent agent;
    private Animator animator;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, target.position) > 1f)
        {
            agent.isStopped = false;
            agent.SetDestination(target.position);
            animator.SetBool("running", true);
        }
        else
        {
            agent.isStopped = true;
            animator.SetBool("running", false);
        }
       
    }
    
}
