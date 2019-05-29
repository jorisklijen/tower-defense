using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class menu : MonoBehaviour
{
    /* TO DO LIST 
    *  basis levens geven 
    *  enemys damage laten doen 
    */

    public string sceneName;
    public Animator trasitionAnim;

    public AudioMixer audioMixer;


    //niet helemaal netjese maar de eerste anim n wilde niet stoppen met afspeel dus heb t zo maar ge fixt :)
    void Start()
    {
        StartCoroutine(IdleStart());
    }
    IEnumerator IdleStart()
    {
        yield return new WaitForSeconds(1.51f);
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


    

    // hier zijn de aoudi sliders van maste, muziek en sfx.
    public void SetMasterVolume (float masterVolume)
    {
        audioMixer.SetFloat("MasterVolume", masterVolume);
    }
    public void SetMuziekVolume(float muziekVolume)
    {
        audioMixer.SetFloat("MusicVolume", muziekVolume);
    }
    public void SetSFXVolume(float sfxVolume)
    {
        audioMixer.SetFloat("SFXVolume", sfxVolume);
    }




    // sluit het spel af
    public void QuitGame ()       
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
