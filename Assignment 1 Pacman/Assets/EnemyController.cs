using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public GameObject[] wayPoints;
    public Transform player;

    private NavMeshAgent enemyAgent;
    private Transform currentDestination;
    private int currentIndex = 0;
    private int finalIndex;
    private float minDist = 0.1f;

    // private bool pursuing = false;
    // private float pursuingTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        enemyAgent = GetComponent<NavMeshAgent>();
        finalIndex = wayPoints.Length;
        currentDestination = wayPoints[currentIndex].transform;
        enemyAgent.SetDestination(currentDestination.position);
        // Debug.Log(Vector3.Distance(wayPoints[2].transform.position, wayPoints[3].transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentIndex);
        if (enemyAgent.remainingDistance <= minDist)
        {
            currentIndex += 1;
            if (currentIndex >= finalIndex)
            {
                currentIndex = 0;
            }
            currentDestination = wayPoints[currentIndex].transform;
        }
        enemyAgent.SetDestination(currentDestination.position);
    }

    private void FixedUpdate()
    {
        Ray ray = new Ray(transform.position, player.position - transform.position);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Player")
        {
            currentDestination = hit.transform;
        }
        else
        {
            currentDestination = wayPoints[currentIndex].transform;
        }
    }
}
