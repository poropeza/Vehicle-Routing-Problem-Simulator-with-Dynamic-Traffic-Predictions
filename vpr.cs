/*using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
#if UNITY_EDITOR
using UnityEditor;
#endif





public class vpr : MonoBehaviour {

	// Use this for initialization

	GameObject cylinder;
	NavMeshAgent agent;
	Transform goal;

    

	void Start () 
	{
		//BuildSlope90 ();

		//cylinder = GameObject.Find ("camion_pemex");



		agent = GetComponent<NavMeshAgent>();
		goal= GameObject.Find("Cube").transform;
		agent.destination = goal.position;

	
	}
	
	// Update is called once per frame
	void Update ()
	{
		//agent = cylinder.GetComponent<NavMeshAgent>();
		agent.destination = goal.position;

        Vector3 pos = agent.transform.position;


        if (pos.x >= 21027 && pos.y >= 20922 && pos.z >= 41785) //está en el espacio apto para teletransportarse
        {
            agent.transform.position = new Vector3(20570, 20924, 41785);
            
        }
	
	}

    /*

	[MenuItem("NavMesh/Build With Slope 90")]
	public static void BuildSlope90()
	{
		SerializedObject obj = new SerializedObject(NavMeshBuilder.navMeshSettingsObject);
		SerializedProperty prop = obj.FindProperty("m_BuildSettings.agentSlope");
		prop.floatValue = 90.0f;
		obj.ApplyModifiedProperties();
		NavMeshBuilder.BuildNavMesh();
	}
    */
//}



/*
public void teleportTo(Vector3 point)
{
    //Change the position
    transform.position = point;

    // Warp should always be used when a NavMeshAgent is moved to keep them in-sync
    if (GetComponent<AICharacterControl>())
    {
        GetComponent<AICharacterControl>().agent.Warp(point);
    }
}
*/
