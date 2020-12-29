/*using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class vrp2 : MonoBehaviour {

    // Use this for initialization

    GameObject cylinder;
    NavMeshAgent agent;
    Transform goal;

    void Start()
    {
        //BuildSlope90 ();

        //cylinder = GameObject.Find ("camion_pemex");



        agent = GetComponent<NavMeshAgent>();
        goal = GameObject.Find("Cube (1)").transform;
        agent.destination = goal.position;


    }

    // Update is called once per frame
    void Update()
    {
        //agent = cylinder.GetComponent<NavMeshAgent>();
        agent.destination = goal.position;

        Vector3 pos = agent.transform.position;


        if (pos.x <= 20560 && pos.y >= 20925 && pos.z >= 41800) //está en el espacio apto para teletransportarse
        {
            agent.transform.position = new Vector3(21017, 20926, 41809);
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




