using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Splash : MonoBehaviour 
{
    public float timer;
    public float changeSceneTime;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
        timer += Time.deltaTime;

        if (timer > changeSceneTime)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
	    
	}
}
/*
	"Don't let your dreams be dreams."
					- Shia LaBeouf
*/