using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class だきまくら : MonoBehaviour 
{
    public GameObject warning;
    public GameObject DEAD;

    public float timer;
    public float GameOverTimer;

    public bool isAlive = true;

    public Mesh NORMAL;
    public Mesh DIE;

    public AudioSource music;

    public AudioSource だきまくらどたばたSOURCE;
    public AudioClip[] だきまくらどたばた;

    public float かわいいLV;
    public float とぷかわいい;
    public float kawaiiDecayRate;

	// Use this for initialization
	void Start () 
	{
        だきまくらどたばたSOURCE = FindObjectOfType<だきまくら>().GetComponent<AudioSource>();
        DEAD = GameObject.Find("DEAD");
        DEAD.SetActive(false);
        warning = GameObject.Find("warning");
        warning.SetActive(false); 
    }
	
	// Update is called once per frame
	void Update () 
	{
	    if (かわいいLV > 0)
        {
            かわいいLV -= kawaiiDecayRate * Time.deltaTime;
        }

        if (かわいいLV <= 25)
        {
            gameObject.GetComponent<MeshFilter>().mesh = DIE;
            warning.SetActive(true);
        }
        else if (かわいいLV > 25)
        {
            warning.SetActive(false);
            GetComponent<MeshFilter>().mesh = NORMAL;
        }
        if (かわいいLV <= 0)
        {
            isAlive = false;
        }

        if (!isAlive)
        {
            DEAD.SetActive(true);
            timer += Time.deltaTime;
            music.Stop();
            if (timer >= GameOverTimer)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
	}

    public void どたばたPLAY()
    {
        int RANDOM = Random.Range(0, 3);

        だきまくらどたばたSOURCE.clip = だきまくらどたばた[RANDOM];

        if (RANDOM == 2)
        {
            かわいいLV -= 20;
        }

        だきまくらどたばたSOURCE.Play();
    }

}
/*
	"Don't let your dreams be dreams."
					- Shia LaBeouf
*/