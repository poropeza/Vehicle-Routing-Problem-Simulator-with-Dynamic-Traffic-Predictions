using UnityEngine;
using System.Collections;

public class avionetaS : MonoBehaviour {

    public float speed = 105f;
    public Vector3 direction = Vector3.back;
    public void Update()
    {
        transform.Translate(direction * speed);
    }
}

