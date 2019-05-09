using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Geschreven door Joris de Kleijn [2-5-2019 19:00] 
/// </summary>

public class Spawner : MonoBehaviour
{
    public Transform enemy;
    [Space]
    public Transform spawnPoint;
    [Space]
    public float tijdTusenWaves = 5f;
    // De tijd voor dat de eerste wave komt
    private float countdown = 6f;
   // [Space]
    private int waveIndex = 0; 

    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = tijdTusenWaves;
        }

        countdown -= Time.deltaTime;

    }


    /// <summary>
    /// corotine zorgt dat er een nieuwe groep vijhanden aankomen maar ze wel allemaal na elkaar spawnen
    /// </summary>
    IEnumerator SpawnWave ()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.2f);//----------------------------------- hier staat de tijd voor de induvuliwwele spawns van de enemys NIET DE SPAWNS VAN WAVES 
        }
        
    }

    /// <summary>
    /// spawnd de ennemy op de goede plaats en met de goede rotaatie
    /// </summary>
    void SpawnEnemy()
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }
}
