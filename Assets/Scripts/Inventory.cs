using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class Inventory : MonoBehaviour {

    private float space = 0;
    private int lvl= GameManager.level;

    public void Awake()
    {
          
    }
    public void Update()
    {
        if (GameManager.level != lvl)
        {
            space = 0;
            lvl = GameManager.level;
        }
       }
  

    public void CreateIcon()
    {
        string str = GameManager.CurrentCollision;
#if UNITY_EDITOR    
        Sprite spr = AssetDatabase.LoadAssetAtPath("Assets/"+str+".png",typeof(Sprite)) as Sprite;
#endif

        GameObject go = new GameObject();
        go.AddComponent<Image>();
        go.transform.parent = GameObject.FindGameObjectWithTag("Inventory").transform;
        go.GetComponent<Image>().rectTransform.localPosition = new Vector3(35+(space*13f),0f,0f);
        go.GetComponent<Image>().rectTransform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        go.GetComponent<Image>().sprite = spr;
        space++;
            
        
    }

}
    