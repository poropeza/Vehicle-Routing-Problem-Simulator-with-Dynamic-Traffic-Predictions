using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Return()
    {
        //Application.LoadLevel("menu");
		SceneManager.LoadScene ("menu");

    }
}
