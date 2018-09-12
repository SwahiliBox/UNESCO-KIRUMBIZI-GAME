using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuStart : MonoBehaviour
{
    bool isMute;

    public void changeScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void quitGame()
    {
        Application.Quit();
    }
    public void muteButton()
    {
        isMute = !isMute;
        AudioListener.volume = isMute?0:1;
    }

}