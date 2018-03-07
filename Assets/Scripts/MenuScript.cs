using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public void onePlayerButton()
    {
        SceneManager.LoadScene(3);
    }

    public void twoPlayerButton()
    {
        SceneManager.LoadScene(6);
    }

    public void creditsButton()
    {
        SceneManager.LoadScene(1);
    }

    public void highScoreButton()
    {
        SceneManager.LoadScene(2);
    }

    public void menuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void exitButton()
    {
        Application.Quit();
    }

    public void gameModeButton()
    {
        SceneManager.LoadScene(5);
    }

}
