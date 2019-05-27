using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    /* TO DO LIST JORIS 
    *  settings maaken
    *  spawner af maaken 
    *  basis levens geven 
    *  enemys damage laten doen 
    */

    public string sceneName;
    public Animator trasitionAnim;



    void Start()
    {
        StartCoroutine(IdleStart());
    }

    IEnumerator IdleStart()
    {
        yield return new WaitForSeconds(1.5f);
        trasitionAnim.SetTrigger("IdleStart");
    }


    public void LoadToBTN()
    {
        StartCoroutine(LoadScene());
    }

    
    // zorgt ervoor de de scene pas geladen word na dat de anmim voor bij is.
    IEnumerator LoadScene()
    {
        trasitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }

    

    public void QuitGame ()       
    {
        Debug.Log("QUIT");
        Application.Quit();
    }








}
