using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class base_datos : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
       // test();
        StartCoroutine(test()); //inicia el hilo en paralelo
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator test()
    {
        WWW conec = new WWW("http://localhost/den/test.php?day=Miercoles&hr=7:00");
        yield return (conec);
       // Debug.Log(conec.text);

        string[] area = conec.text.Split(new string[] { "<br>" }, StringSplitOptions.None);


        foreach (string word in area)
        {
            Debug.Log(word);
        }


        
    }
}
