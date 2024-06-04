using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Lesson67_Exercises : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        agent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit))
            {
                agent.SetDestination(raycastHit.point);
                agent.angularSpeed = 500;
                
            }
        }
        if (agent.velocity == Vector3.zero)
        {
            animator.SetInteger("Speed", 0);
        }
        else
        {
            animator.SetInteger("Speed", 1);
        }
    }
}
