using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PouletScript : MonoBehaviour
{
    public int PV;


    private NavMeshAgent agent;
    

    public LayerMask whatIsGround, whatIsPlayer;

    private Animator animator;
    private Collider Collider;
    //patroling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;
    private void Awake()
    {

        agent = GetComponent<NavMeshAgent>();
        
        animator = GetComponent<Animator>();
        Collider = GetComponent<Collider>();
    }
    private void Patroling()
    {
        if (!walkPointSet) SearchWalkPoint();

        if (walkPointSet)
        {

            animator.Play("Walk In Place");
            agent.SetDestination(walkPoint);
        }
        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //Walkpoint Reached
        if (distanceToWalkPoint.magnitude < 1f) walkPointSet = false;

    }
    private void SearchWalkPoint()
    {
        //Calcul un point dans le "Range" au hazard
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround)) { walkPointSet = true; }
    }
    private void Die()
    {
        agent.SetDestination(transform.position);
        animator.Play("Turn Head");
        GameObject.Destroy(this.gameObject, 1.33f);
    }
    void Update()
    {
      
      

       Patroling();
        
      
        if (PV <= 0) { Die(); }
    }
}
