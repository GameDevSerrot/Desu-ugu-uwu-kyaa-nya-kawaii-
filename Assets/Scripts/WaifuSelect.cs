using UnityEngine;
using System.Collections;

public class WaifuSelect : MonoBehaviour 
{
    public Material gandalf;
    public Material dumbledore;
    public Material tim;

    public だきまくら だきまくら;

    public AudioSource music;

    public GameObject characterSelect; 

    public void Gandalf()
    {
        だきまくら.GetComponent<Renderer>().material = gandalf;
        characterSelect.SetActive(false);
        music.Play();
    }

    public void Dumbledore()
    {
        だきまくら.GetComponent<Renderer>().material = dumbledore;
        characterSelect.SetActive(false);
        music.Play();
    }

    public void Tim()
    {
        だきまくら.GetComponent<Renderer>().material = tim;
        characterSelect.SetActive(false);
        music.Play();
    }

}
/*
	"Don't let your dreams be dreams."
					- Shia LaBeouf
*/