using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking : MonoBehaviour {



    
    void Start ()
    {
        
	}


    void Update()
    {
        StartCoroutine(tracking());
    }
     IEnumerator tracking()
    {   
        yield return new WaitForSeconds(3f);
        GameManager.trans = transform;
    }
}
