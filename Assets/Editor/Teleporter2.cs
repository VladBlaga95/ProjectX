using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class Teleporter2 : MonoBehaviour
{
	float time=0f;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		time += Time.deltaTime;
		if(time>30)
			EditorSceneManager.LoadScene ("Mineshaft");
	}
}

