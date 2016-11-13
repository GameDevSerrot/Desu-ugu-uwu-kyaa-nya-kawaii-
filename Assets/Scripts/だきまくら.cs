using UnityEngine;
using System.Collections;

public class だきまくら : MonoBehaviour 
{
    public float かわいいLV;
    public float とぷかわいい;
    public float kawaiiDecayRate;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	    if (かわいいLV > 0)
        {
            かわいいLV -= kawaiiDecayRate * Time.deltaTime;
        }
	}
}
/*
	"Don't let your dreams be dreams."
					- Shia LaBeouf
*/