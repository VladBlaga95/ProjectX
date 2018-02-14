using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;
using UnityEngine.Video;
public class TransitionEffect : MonoBehaviour {

    public Camera cam;
    public SepiaTone sepia;
    public EdgeDetection edge;
    public NoiseAndScratches nas;
    public VideoPlayer vps;
	void Start ()

    {
        sepia = cam.GetComponent<SepiaTone>();
        edge = cam.GetComponent<EdgeDetection>();
        nas = cam.GetComponent<NoiseAndScratches>();
        edge.edgesOnly = 1;
        edge.sensitivityNormals = 1;
        edge.sensitivityDepth = 1;
	}

	void Update ()
    {if (!vps.isPlaying)
        {
            if (edge.edgesOnly > 0 && edge.sensitivityDepth > 0 && edge.sensitivityNormals > 0)
            {
                StartCoroutine(tranzition());
            }
            else
            {
                edge.enabled = false;
                sepia.enabled = false;
                nas.enabled = false;
            }
        }

    }
    IEnumerator tranzition()
    {
        yield return new WaitForSeconds(0.5f);
        edge.edgesOnly -= 0.033f;
        edge.sensitivityDepth -= 0.033f;
        edge.sensitivityNormals -= 0.033f;
    }
}
