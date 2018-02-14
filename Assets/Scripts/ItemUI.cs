using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUI : MonoBehaviour {

    public GameObject ui;
    public GameObject gotemp;
    public bool CollisionEnter = false;
   
   
    void Start ()
    {

    }
    void Update()
    {
  
           
    }
    void OnCollisionEnter(Collision collision)
    {   
        if (collision.gameObject.tag == "Player")
        {
            if (CollisionEnter == false)
            {
                Instantiate(ui, new Vector3(0, 0, 0), Quaternion.identity);
                GameManager.CurrentCollision = tag;
                CollisionEnter = true;
                GameManager.temp = gotemp;
            }




        }
    }

    void OnCollisionLeave(Collision collision)
    {   if (collision.gameObject.tag == "Player")
        {
           
            GameManager.temp = null;
            GameManager.ToBeDestroyed = false;
            CollisionEnter = false;
            Destroy(GameObject.FindGameObjectWithTag("ItemUI"));
            
        }
    }

}
