using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    /* TO DO LIST JORIS 
    *  corotiens toeveogen  mee bezig
    *  geluid op klik knop 
    *  saettings maakewn
    *  spawner af maaken */

    public string sceneName;
    public Animator trasitionAnim;



    void Start()
    {
        StartCoroutine(IdleStart());
    }

    IEnumerator IdleStart()
    {
        yield return new WaitForSeconds(2.0f);
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
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(sceneName);
    }

    

    public void QuitGame ()       
    {
        Debug.Log("QUIT");
        Application.Quit();
    }








}
