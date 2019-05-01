using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KlikToMoveControler : MonoBehaviour
{
	public Camera Cam;


    // Update is called once per frame
    void Update()
    {
		if (Input.GetMoudeButtonDown(0))
		{
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			
		}
    }
}
