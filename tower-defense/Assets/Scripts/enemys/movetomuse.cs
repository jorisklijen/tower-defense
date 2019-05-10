using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;//--------------------------------------------------- nodig voor navmesh scripting

/// <summary>
/// Geschreven door Joris de Kleijn [2-5-2019 12:00] 
/// </summary>

public class movetomuse : MonoBehaviour
{
    // public Camera cam;
    
    public NavMeshAgent agent;
    [Space]  //----------------------------------------------------------- in editor zo dat er een space tussen zit :)
    public Transform target;

    void Update()
    {
        agent.SetDestination(target.position);
        
        //----------------------------------[ Bewoog de enemy naar de muis klik ]-----------------------------------
        //                                                                                                         |
        //   if (Input.GetMouseButtonDown(0))                                                                      |
        //   {                                                                                                     |
        //       Ray ray = cam.ScreenPointToRay(Input.mousePosition);                                              |
        //       RaycastHit hit;                                                                                   |
        //       if (Physics.Raycast(ray, out hit))                                                                |
        //           agent.SetDestination(hit.point);                                                              |
        //   }                                                                                                     |
        //                                                                                                         |
        //----------------------------------------------------------------------------------------------------------
    }
}
