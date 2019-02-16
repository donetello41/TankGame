using UnityEngine;
using UnityEngine.AI;
public class HTankAI : MonoBehaviour {
    NavMeshAgent agent;
    public Transform[] wayPoints;
    Vector3[] points;
    int currentTarget = 0;
    public Transform player;
    float distance;
    Animator fsmAI;
    protected float health;
    HShoot shoot;
    public Transform barrel;
    public GameObject bullet;
    void Start () {
        fsmAI = GetComponent<Animator>();
        points = new Vector3[2];
        agent = GetComponent<NavMeshAgent>();
        points[0] = wayPoints[0].position;
        points[1] = wayPoints[1].position;
        agent.SetDestination(points[currentTarget]);
        shoot = FindObjectOfType<HShoot>();
    }
	void Update ()
    {
        if(player != null) {
            distance = Vector3.Distance(player.position, transform.position);
            fsmAI.SetFloat("distance", distance);
        }
        float distanceFromWayPoint = Vector3.Distance(points[currentTarget], transform.position);
        fsmAI.SetFloat("distanceFromWayPoint", distanceFromWayPoint);
    }

    public void PatrolState()
    {
        agent.SetDestination(points[currentTarget]);
    }

    public void FindNewWayPoint()
    {
        switch (currentTarget)
        {
            case 0:
                currentTarget = 1;
                break;
            case 1:
                currentTarget = 0;
                break;
        }
    }
    public void ChaseState()
    {
        agent.SetDestination(player.transform.position);
    }
    public void Turn()
    {   if (!player)
            return;
        agent.SetDestination(player.transform.position);
    }

    public void ShootState()
    {
        shoot.Shoot(barrel, bullet);
    }

}
