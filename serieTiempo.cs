using UnityEngine;
using System.Collections;

public class serieTiempo : MonoBehaviour {


	public float[] x = new float[12];
	private float alfa = 0.7f;
	public Material[] matt = new Material[4];
	nvvv respaldo;
	GameObject respaldop;
	float f;

	// Use this for initialization
	void Start()
	{
		respaldop= GameObject.Find("nav");
		respaldo= respaldop.GetComponent<nvvv>();
		//Debug.Log (respaldo);


		/*Material verde =Resources.Load ("Materials/BOTTOM_1",typeof(Material)) as Material;
		Material amarillo = Resources.Load ("Materials/_Color_D01_2",typeof(Material)) as Material;
		Material rojo = Resources.Load ("Materials/M_0020_Red",typeof(Material)) as Material;
		Material vinotinto = Resources.Load ("Materials/M_0022_Maroon",typeof(Material)) as Material;*/

		//Debug.Log (vinotinto);

		for(int i=0;i<12;i++)
		{
			//Debug.Log (respaldo.zones[i]);
			if (i == 0) 
			{
				x [i] = respaldo.zones[i];
			} 
			else 
			{
				x [i] = x [i - 1] + alfa * (respaldo.zones[i - 1] - x [i - 1]);

			}

		}

		MeshRenderer mat;

		for (int i = 0; i < 12; i++)
		{
			switch (i)
			{
			case 0:
				f = x [i];

				mat = GameObject.Find ("zone1").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];
					
				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
					

					break;
				case 1:
				f = x [i];

				mat = GameObject.Find ("zone2").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
					break;
				case 2:
				f = x [i];

				mat = GameObject.Find ("zone3").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
					break;
				case 3:
				f = x [i];

				mat = GameObject.Find ("zone4").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
					break;
				case 4:
				f = x [i];

				mat = GameObject.Find ("zone5").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
					break;
				case 5:
				f = x [i];

				mat = GameObject.Find ("zone6").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
					break;
				case 6:
				f = x [i];

				mat = GameObject.Find ("zone7").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}


				mat = GameObject.Find ("zone70").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}

				mat = GameObject.Find ("zone71").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}


				mat = GameObject.Find ("zone72").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}


				mat = GameObject.Find ("zone73").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}


				mat = GameObject.Find ("zone74").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}


				mat = GameObject.Find ("zone75").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}

					break;
				case 7:
				f = x [i];

				mat = GameObject.Find ("zone8").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
					break;
				case 8:
				f = x [i];

				mat = GameObject.Find ("zone9").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
					break;
				case 9:
				f = x [i];

				mat = GameObject.Find ("zone10").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
					break;
				case 10:
				f = x [i];

				mat = GameObject.Find ("zone11").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
					break;
				case 11:
				f = x [i];

				mat = GameObject.Find ("zone12").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
					break;
			

			}
		}

	
	}
	
	// Update is called once per frame
	void Update () 
	{
		

		/*Material verde =Resources.Load ("Materials/BOTTOM_1",typeof(Material)) as Material;
		Material amarillo = Resources.Load ("Materials/_Color_D01_2",typeof(Material)) as Material;
		Material rojo = Resources.Load ("Materials/M_0020_Red",typeof(Material)) as Material;
		Material vinotinto = Resources.Load ("Materials/M_0022_Maroon",typeof(Material)) as Material;*/

		//Debug.Log (vinotinto);

		for(int i=0;i<12;i++)
		{
			//Debug.Log (respaldo.zones[i]);
			if (i == 0) 
			{
				x [i] = respaldo.zones[i];
			} 
			else 
			{
				x [i] = x [i - 1] + alfa * (respaldo.zones[i - 1] - x [i - 1]);

			}

		}

		MeshRenderer mat;

		for (int i = 0; i < 12; i++)
		{
			switch (i)
			{
			case 0:
				f = x [i];

				mat = GameObject.Find ("zone1").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}


				break;
			case 1:
				f = x [i];

				mat = GameObject.Find ("zone2").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
				break;
			case 2:
				f = x [i];

				mat = GameObject.Find ("zone3").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
				break;
			case 3:
				f = x [i];

				mat = GameObject.Find ("zone4").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
				break;
			case 4:
				f = x [i];

				mat = GameObject.Find ("zone5").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
				break;
			case 5:
				f = x [i];

				mat = GameObject.Find ("zone6").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
				break;
			case 6:
				f = x [i];

				mat = GameObject.Find ("zone7").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
				break;
			case 7:
				f = x [i];

				mat = GameObject.Find ("zone8").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
				break;
			case 8:
				f = x [i];

				mat = GameObject.Find ("zone9").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
				break;
			case 9:
				f = x [i];

				mat = GameObject.Find ("zone10").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
				break;
			case 10:
				f = x [i];

				mat = GameObject.Find ("zone11").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}
				break;
			case 11:
				f = x [i];

				mat = GameObject.Find ("zone12").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}


				mat = GameObject.Find ("zone120").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}

				mat = GameObject.Find ("zone121").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}

				mat = GameObject.Find ("zone122").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}

				mat = GameObject.Find ("zone123").GetComponent<MeshRenderer> ();
				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}

				mat = GameObject.Find ("zone124").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}

				mat = GameObject.Find ("zone125").GetComponent<MeshRenderer> ();

				if (x [i] < 25) {
					mat.material = matt[0];

				} else if (x [i] >= 25 && x [i] < 50) 
				{
					mat.material = matt[1];
				}
				else if (x [i] >= 50 && x [i] < 75) 
				{
					mat.material = matt[2];
				}
				else if (x [i] >=75) 
				{
					mat.material = matt[3];
				}



				break;


			}
		}
	
	}


}
