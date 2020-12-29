using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void Model()
    {
        //Application.LoadLevel("input");
		SceneManager.LoadScene ("input");
    }

    public void About()
    {
        //Application.LoadLevel("acerca");
		SceneManager.LoadScene ("acerca");
    }

    public void Exit()
    {
        //StartCoroutine(test()); //inicia el hilo en paralelo
        Application.Quit();
    }

   /* IEnumerator test()
    {
        WWW conec = new WWW("http://localhost/den/test.php");
        yield return (conec);

        string[] words = conec.text.Split(new string[] { "<br>" }, StringSplitOptions.None);
        

        foreach (string word in words)
        {
            Debug.Log(word);
        }

        
    }
    */
}
