using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movetomuse : MonoBehaviour
{
   // public Camera cam;
    public NavMeshAgent agent;
    public Vector3 target;

    void Update()
    {
        agent.SetDestination(target);

     //   if (Input.GetMouseButtonDown(0))
     //   {
     //       Ray ray = cam.ScreenPointToRay(Input.mousePosition);
     //       RaycastHit hit;
     //
     //       if (Physics.Raycast(ray, out hit))
     //       {
     //           agent.SetDestination(hit.point);
     //       }
     //   }
    }
}
