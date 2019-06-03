using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyTowerScript : MonoBehaviour
{
    public int moneyDropSeconds;
    public float moneyPerDrop;
    public BuildManager b;

    private void Start()
    {
        StartCoroutine(Money());
    }

    IEnumerator Money()
    {
        //geeft x aantal geld elke x aantal seconden
        yield return new WaitForSeconds(moneyDropSeconds);
        b.money = b.money + moneyPerDrop;
        StartCoroutine(Money());
    }
}
