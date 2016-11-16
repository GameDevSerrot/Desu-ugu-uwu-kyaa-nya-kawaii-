using UnityEngine;
using System.Collections;

public class ウイーアブー : MonoBehaviour
{
    public AudioSource ウイーアブーどたばたSOURCE;
    public AudioClip[] ウイーアブーどたばた;
    public Camera CAMERA;
    public だきまくら だきまくら;







    // Use this for initialization
    void Start ()
    {
        ウイーアブーどたばたSOURCE = FindObjectOfType<ウイーアブー>().GetComponent<AudioSource>();
        CAMERA = FindObjectOfType<KawaiiCamera>().GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        RaycastHit hit;
 
        if (だきまくら.isAlive)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = CAMERA.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.CompareTag("だきまくら"))
                    {
                        if (だきまくら.かわいいLV <= だきまくら.とぷかわいい - 10.0f)
                        {
                            だきまくら.かわいいLV += 20.0f;
                            だきまくら.どたばたPLAY();

                        }
                        だきまくら.どたばたPLAY();
                        だきまくら.kawaiiDecayRate *= 2;

                    }
                }
            }
        }

	}

    public void どたばたPLAY()
    {
        int RANDOM = Random.Range(0, 7);

        ウイーアブーどたばたSOURCE.clip = ウイーアブーどたばた[RANDOM];
        ウイーアブーどたばたSOURCE.Play();
        だきまくら.kawaiiDecayRate *= .5f;
    }
}
