using System.Collections;
using UnityEngine;
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


    //niet helemaal netjese maar de eerste anim n wilde niet stoppen met afspeel dus heb t zo maar ge fixt :)
    void Start()
    {
        StartCoroutine(IdleStart());
    }
    IEnumerator IdleStart()
    {
        yield return new WaitForSeconds(1.5f);
        trasitionAnim.SetTrigger("IdleStart");
    }



    // zorgt ervoor de de scene pas geladen word na dat de anmim voor bij is.
    public void LoadToBTN()
    {
        StartCoroutine(LoadScene());
    }
    IEnumerator LoadScene()
    {
        trasitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }


    
    // sluit het spel af
    public void QuitGame ()       
    {
        Debug.Log("QUIT");
        Application.Quit();
    }








}
