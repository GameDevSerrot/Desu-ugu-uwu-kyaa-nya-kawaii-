using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
/*
	"Don't let your dreams be dreams."
					- Shia LaBeouf
*/