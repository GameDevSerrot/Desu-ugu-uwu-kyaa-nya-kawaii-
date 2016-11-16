using UnityEngine;
using System.Collections;

public class KawaiiCamera : MonoBehaviour 
{
    private GameObject neck;
    public float rotateSpeed = 5;

    private bool moving = true;

    void Start()
    {
        neck = GameObject.Find("ウイーアブー");
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            moving = !moving;
        }
        if (moving)
        {
            float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
            float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;

            neck.transform.Rotate(0, horizontal, 0);
            transform.Rotate(-vertical, 0, 0);
        }
    }
}
/*
	"Don't let your dreams be dreams."
					- Shia LaBeouf
*/