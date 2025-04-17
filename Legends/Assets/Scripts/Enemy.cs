using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Collider swordCollider;
    private NavMeshAgent agent;
    private Animator animator;
    private bool isDead = false;
    

    private void Start()
    {
        swordCollider.enabled = false;
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    public void StartAttack()
    {
        swordCollider.enabled = true;
    }
    public void EndAttack()
    {
        swordCollider.enabled = false;
    }

    public void OnDeath()
    {
        Debug.Log(name + "_DEAD");
        isDead = true;
        agent.isStopped = false;
    }

    private void Update()
    {
        if (isDead)
            return;
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
            //  if (Time.time - lastHitTime > attackInterval)
           // {
            //    lastAttackTime = Time.time
             //   animator.SetTrigger("attck");
           // }
        }
       
    }
    
}
