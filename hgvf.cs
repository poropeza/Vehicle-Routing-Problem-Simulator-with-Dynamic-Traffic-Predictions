using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public class hgvf : MonoBehaviour {

	void awake()
	{
		
		//nvvv.DontDestroyOnLoad (nvvv);

	}

    public void exit()
    {
       // Application.LoadLevel("menu");
		GameObject respaldop = GameObject.Find("nav");
		Destroy (respaldop);
		serieTiempo st= GameObject.Find("proc").GetComponent<serieTiempo>();
		st.x = null;
		SceneManager.LoadScene ("menu");

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
