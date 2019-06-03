using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgardeScript : MonoBehaviour
{
    public GameObject nextTierTurret;
    public GameObject currendTierTurred;
    private GameObject oldOne;

    private void OnMouseDown()
    {
        // wanneer je op een turret klikt gaat ie upgraden

//----------------------------------------------[heb ik toegevoegt]---------------------------------------------//
        if (true)
        {
            oldOne = currendTierTurred;
            currendTierTurred = nextTierTurret;

            Instantiate(currendTierTurred, transform.position, transform.rotation);
        }

//----------------------------------------------[heb ik toegevoegt]---------------------------------------------//



        //joris// dit gaat zo niet weken je moet eest nog een nieuw e maaken voor dat je m ver wijderd;

        Destroy(oldOne); // heb er old one van gemaakt

        //NOG NIET AF!
        //hier moet nog een mechanic voor upgrades die geld kosten
    }
}
