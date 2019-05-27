using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void PlayMainGame()
    {
        SceneManager.LoadScene("MAIN");
    }

    public void BackToMainGame()
    {
        SceneManager.LoadScene("menu");
    }




    public void QuitGame ()                                                                                                                                                                                 //hoi
    {
        Debug.Log("QUIT");
        Application.Quit();
    }








}
