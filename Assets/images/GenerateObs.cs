using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour

{
	int score = 0;
	public GameObject rocks;
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 1.5f);
	}

	void CreateObstacle()

	{
		Instantiate(rocks);
		score++;
	}

	void OnGUI()
	{

		GUI.color = Color.black;
		GUILayout.Label("Score :" + score.ToString());
	}

	// Update is called once per frame
	void Update()
	{

	}
}
