using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CameraEnable : MonoBehaviour {

    public Camera cam;
    public Camera camGame;
    public VideoPlayer vp;
    public GameObject ui;

    private bool generateUI;
	void Start () {
        generateUI = false;
    }
	
	void Update () {

        if (vp.isPlaying == false)
        {
            cam.enabled = false;
            camGame.enabled = true;
            if (!generateUI)
            {Instantiate(ui, new Vector3(0, 0, 0), Quaternion.identity);
            generateUI = true;
        }
        }

	}
}
