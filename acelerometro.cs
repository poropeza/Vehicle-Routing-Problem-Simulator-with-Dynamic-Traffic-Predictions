using UnityEngine;
using System.Collections;



public class acelerometro : MonoBehaviour
{
    float speed = 5.0f;
    Transform target;


	// Use this for initialization
	void Start () {

        target= GameObject.Find("Main Camera").transform;

    }
	
	// Update is called once per frame
	void Update ()
    {
        //transform.Rotate(Input.acceleration.x, Input.acceleration.y, -Input.acceleration.z);

        if (Input.GetMouseButton(0))
        {
            transform.LookAt(target);
            transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse X") * speed);
        }
    }

}



