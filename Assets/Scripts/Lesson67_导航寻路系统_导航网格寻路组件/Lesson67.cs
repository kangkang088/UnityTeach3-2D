using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Lesson67 : MonoBehaviour
{
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        //agent.SetDestination(Vector3.zero);
        //agent.isStopped = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit rayCastHit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayCastHit))
            {
                print(rayCastHit.collider.name);
                agent.isStopped = false;
                agent.SetDestination(rayCastHit.point);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            agent.isStopped = true;
        }
    }
}
