using UnityEngine;
using UnityEditor.SceneManagement;
using System.Collections;

public class OnPortalEnter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		switch (collision.gameObject.tag) 
		{
		case "Mineshaft":
				//EditorSceneManager.LoadScene ("Mineshaft");break;
				Debug.Log ("I have enter the Mineshaft Realm");break;
		case "Egypt":
			//EditorSceneManager.LoadScene ("Egypt");break;
			Debug.Log("I have enter the Egypt Realm");break;
		case "Castle":
			//EditorSceneManager.LoadScene ("Castle");break;
			Debug.Log("I have enter the Castle Realm");break;
		case "Igloo":
			//EditorSceneManager.LoadScene ("Igloo");break;
			Debug.Log("I have enter the Igloo Realm");break;
		case "City":
			//EditorSceneManager.LoadScene ("City");break;
			Debug.Log("I have enter the City Realm");break;
		}

	}

}
