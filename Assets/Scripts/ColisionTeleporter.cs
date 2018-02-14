using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ColisionTeleporter : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {      if (col.gameObject.tag == "Portal")
        {
            
            GameManager.ToUpdate = true;
            GameManager.level++;
            SceneManager.LoadScene(GameManager.level);
            
        }
          
       
    }
}