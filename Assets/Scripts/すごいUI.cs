using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class すごいUI : MonoBehaviour 
{
    public Image かわいいLV;
    public だきまくら だきまくら;

    void Start () 
	{
        だきまくら = FindObjectOfType<だきまくら>();
        かわいいLV = GameObject.Find("すごいBAR").GetComponent<Image>();
	}
	
	void Update () 
	{
        かわいいLV.fillAmount = だきまくら.かわいいLV / だきまくら.とぷかわいい;
    }
}




