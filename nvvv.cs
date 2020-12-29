using UnityEngine;
using System.Collections;
using System;
using System.Text;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class nvvv : MonoBehaviour 
{
	public int[] zones = new int[12];
	public System.Random srand = new System.Random((int)DateTime.Now.Ticks);//semilla para que no sea siempre el mismo patrón de valores aleatorios


    public void modelate()
    {
        Text day = GameObject.Find("dia").GetComponent<Text>();
        Text hour = GameObject.Find("hora").GetComponent<Text>();


		GameObject respaldo = GameObject.Find("nav");
   

        StartCoroutine(test(day.text,hour.text)); //inicia el hilo en paralelo


		DontDestroyOnLoad(respaldo.gameObject);

		SceneManager.LoadScene ("prueba");
		//DontDestroyOnLoad(respaldo.gameObject);

    }

    public void returnn()
    {
        //Application.LoadLevel("menu");



		SceneManager.LoadScene ("menu");
    }

    public IEnumerator test(string d, string h)
    {
        if (d == "Monday")
        {
            d = "Lunes";
        }
        else if (d == "Tuesday")
        {
            d = "Martes";
        }
        else if (d == "Wednesday")
        {
            d = "Miercoles";
        }
        else if (d == "Thursday")
        {
            d = "Jueves";
        }
        else
            d = "Viernes";

        WWW conec = new WWW("http://localhost/den/test.php?day="+d+"&hr="+h);
        yield return (conec);
        // Debug.Log(conec.text);

        string[] area = conec.text.Split(new string[] { "<br>" }, StringSplitOptions.None);
        int[] zona = new int[12];
        int it=0;

	

        for(int i = 0; i < area.Length; i++)
        {
           
            if (it < 12)
            {
                if (area[i] == "buena")
                {
					zona [it] = srand.Next(0, 24);
                }
                else if (area[i] == "moderada")
                {
					zona[it] = srand.Next(25, 49);
                }
                else if (area[i] == "pesada")
                {
					zona[it] = srand.Next(50, 74);
                }
                else
                {
					zona[it] = srand.Next(75, 100);
                }
				//Debug.Log (zona[it]);

                it++;
            }

        }


		//el arreglo respaldop.zones[] tendrá las instancias de cada zona según el día y la hora seleccionada
        for(int i = 0; i < 12; i++)
        {
            zones[i] = zona[i];
            //Debug.Log(zones[i]);
            //Debug.Log("\n");
        }

		//
   
    }


}
/*
_instance = GameObject.FindObjectOfType<GameManager>();
                DontDestroyOnLoad(_instance.gameObject);
                */