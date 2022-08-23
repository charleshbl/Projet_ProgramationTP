
using UnityEngine;

using UnityEngine.AI;

//script basé sur le vidéo https://www.youtube.com/watch?v=UjkSFoLxesw 
public class EnemyScript : MonoBehaviour
{
    public int PV ;

    public NavMeshAgent agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    private Animator animator;

    //patroling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //Attacking

    public float timeBetweenAttack;
    bool alreadyAttacked;

    //States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerOutSightRange, playerInAttackRange;

    private void Awake()
    {
       // agent = GetComponent<NavMeshAgent>();
       // player = GameObject.Find("XR Origin").transform;
        animator = GetComponent<Animator>();
    }
    private void Patroling()
    {
        if (!walkPointSet) SearchWalkPoint();

        if (walkPointSet)
        {
            animator.SetBool("IsWalk", true);
            animator.Play("WalkFWD");
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

        if(Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround)) { walkPointSet = true; }
    }
    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
        animator.Play("RunFWD");
    }
    private void AttackPlayer()
    {
        //Make sure enemy doesnt move
        agent.SetDestination(transform.position);
        transform.LookAt(player);
        animator.Play("Attack02");
        if (!alreadyAttacked)
        {
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttack);
        }
    }
    private void ResetAttack()
    {
        alreadyAttacked= false;
    }


    // Update is called once per frame
    void Update()
    {
        // Check si le player est dans le "range")
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange) Patroling();
        if (playerInSightRange && !playerInAttackRange) ChasePlayer();
        if (playerInSightRange && playerInAttackRange) AttackPlayer();
        if (PV == 0) { animator.Play("Die");  }
    }

}
