using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    public enum SpawnState { Spawning, Waitng, Counting }

    [System.Serializable]
    public class Wave
    {
        public string name;
        public Transform enemy;
        public int count;
        public float rate;
    }

    public Wave[] waves;
    private int nextWave = 0;

    public float timeBetweenWaves = 5.0f;
    public float waveCountdown;


    private float searchCountdown = 1.0f;

    private SpawnState State = SpawnState.Counting;

    // Start is called before the first frame update
    void Start()
    {
        waveCountdown = timeBetweenWaves;
    }

    // Update is called once per frame
    void Update()
    {
        if (State == SpawnState.Waitng)
        {
            //kijk of er nog levende enemys zijn    <---hier war ook de knop voor voldende wave

            if (!EnemyIsAlive())
            {
                //begin new round
                Debug.Log("Ronde Compleet");
                return;

            }
            else
            {
                return;
            }
        }


        if (waveCountdown <= 0)
        {
            if (State != SpawnState.Spawning)
            {
                // spawn wave hier 
                StartCoroutine(SpawnWave(waves[nextWave]));
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }

    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0.0f)
        {
            searchCountdown = 1.0f;
            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                return false;
            }
        }
        return true;
    }

    IEnumerator SpawnWave(Wave _wave)
    {
        Debug.Log("Spawing wave" + _wave.name);

        State = SpawnState.Spawning;

        //spawn
        for (int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(1.0f / _wave.rate);
        }

        State = SpawnState.Waitng;

        yield break;
    }

    void SpawnEnemy(Transform _enemy)
    {
        //spawnenemy
        Instantiate(_enemy, transform.position, transform.rotation);
        Debug.Log("Spawning enemy" + _enemy.name);


    }



}


























/*                                                                                                                                                                                                 
                                                                 ohhhhhhhho                                               +hhhhhhhhs                                                                    
                                                                 dMMMMMMMMh                                               yMMMMMMMMm                                                                    
                                                                 dMMMMMMMMh                                               yMMMMMMMMm                                                                    
                                                                 dMMMMMMMMh                                               yMMMMMMMMm                                                                    
                                                                 hNNNNNNMMh`````````                             `````````yMMNNNNNNd                                                                    
                                                                          /MMMMMMMMM:                           -MMMMMMMMM+                                                                             
                                                                          :MMMMMMMMM:                           -MMMMMMMMM/                                                                             
                                                                          :MMMMMMMMM:                           -MMMMMMMMM/                                                                             
                                                                          :MMMMMMMMM:                           -MMMMMMMMM/                                                                             
                                                                 -::::::::oMMMMMMMMMo:::::::::::::::::::::::::::+MMMMMMMMMs::::::::-                                                                    
                                                                 dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm                                                                    
                                                                 dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm                                                                    
                                                                 dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm                                                                    
                                                                 dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm                                                                    
                                                       -sssssssssmMMMMMMMMm+++++++++mMMMMMMMMMMMMMMMMMMMMMMMMMMMm+++++++++dMMMMMMMMNsssssssss-                                                          
                                                       /MMMMMMMMMMMMMMMMMMh         hMMMMMMMMMMMMMMMMMMMMMMMMMMMd         yMMMMMMMMMMMMMMMMMM+                                                          
                                                       /MMMMMMMMMMMMMMMMMMh         hMMMMMMMMMMMMMMMMMMMMMMMMMMMd         yMMMMMMMMMMMMMMMMMM+                                                          
                                                       /MMMMMMMMMMMMMMMMMMh         hMMMMMMMMMMMMMMMMMMMMMMMMMMMd         yMMMMMMMMMMMMMMMMMM+                                                          
                                                       /MMMMMMMMMMMMMMMMMMh         hMMMMMMMMMMMMMMMMMMMMMMMMMMMd         yMMMMMMMMMMMMMMMMMM+                                                          
                                              ymmmmmmmmNMMMMMMMMMMMMMMMMMMNmmmmmmmmmNMMMMMMMMMMMMMMMMMMMMMMMMMMMMmmmmmmmmmNMMMMMMMMMMMMMMMMMMNmmmmmmmmh                                                 
                                              dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm                                                 
                                              dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm                                                 
                                              dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm                                                 
                                              dMMMMMMMMNmmmmmmmmmMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMmmmmmmmmmNMMMMMMMMm                                                 
                                              dMMMMMMMMy         dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm         sMMMMMMMMm                                                 
                                              dMMMMMMMMy         dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm         sMMMMMMMMm                                                 
                                              dMMMMMMMMy         dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm         sMMMMMMMMm                                                 
                                              dMMMMMMMMy         dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm         sMMMMMMMMm                                                 
                                              dMMMMMMMMy         dMMMMMMMMmsssssssssssssssssssssssssssssssssssssssssssssssmMMMMMMMMm         sMMMMMMMMm                                                 
                                              dMMMMMMMMy         dMMMMMMMMh                                               yMMMMMMMMm         sMMMMMMMMm                                                 
                                              dMMMMMMMMy         dMMMMMMMMh                                               yMMMMMMMMm         sMMMMMMMMm                                                 
                                              dMMMMMMMMy         dMMMMMMMMh                                               yMMMMMMMMm         sMMMMMMMMm                                                 
                                              dMMMMMMMMy         dMMMMMMMMh                                               yMMMMMMMMm         sMMMMMMMMm                                                 
                                              -::::::::-         -::::::::+hhhhhhhhhhhhhhhhhho         ohhhhhhhhhhhhhhhhhh+::::::::-         .:::::::::                                                 
                                                                          :MMMMMMMMMMMMMMMMMMh         yMMMMMMMMMMMMMMMMMM/                                                                             
                                                                          :MMMMMMMMMMMMMMMMMMh         yMMMMMMMMMMMMMMMMMM/                                                                             
                                                                          :MMMMMMMMMMMMMMMMMMh         yMMMMMMMMMMMMMMMMMM/                                                                             
                                                                          :MMMMMMMMMMMMMMMMMMh         yMMMMMMMMMMMMMMMMMM/                                                                             
   
*/
