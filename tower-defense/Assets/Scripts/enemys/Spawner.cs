using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Geschreven door Joris de Kleijn [...-5-2019 ...:...] 
/// </summary>

public class Spawner : MonoBehaviour
{
    public Transform enemy;
    [Space]
    public Transform spawnPoint;
    [Space]
    public float tijdTusenWaves = 5f;
    private float countdown = 6f;//--------------------------------------------------- de tijd voor dat de eerste wave komt
    [Space]
    private int waveNumber = 1;

    void Update()
    {
        if (countdown <= 0f)
        {
            SpawnWave();
            countdown = tijdTusenWaves;
        }

        countdown -= Time.deltaTime;

    }


    /// <summary>
    /// zorgt dat er een nieuwe groep vijhanden aankomen 
    /// </summary>
    void SpawnWave ()
    {
        for (int i = 0; i < waveNumber; i++)
            SpawnEnemy();
        waveNumber++;
    }

    /// <summary>
    /// spawnd de ennemy op de goede plaats en met de goede rotaatie
    /// </summary>
    void SpawnEnemy()
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }
}
