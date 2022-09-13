using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform playerPosition;

    private NavMeshAgent enemyAgent;

    // Start is called before the first frame update
    void Start()
    {
        enemyAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, playerPosition.position - transform.position);
        Debug.DrawRay(transform.position, playerPosition.position - transform.position, Color.blue);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        if (hit.collider.tag == "Player")
        {
            enemyAgent.SetDestination(hit.transform.position);
        }
    }
}
