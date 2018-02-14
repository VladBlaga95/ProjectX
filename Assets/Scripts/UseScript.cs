using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseScript : MonoBehaviour {

    private Button btn;

    void Start()
    {
        btn = GetComponent<Button>();
        btn.GetComponent<Button>().onClick.AddListener(delegate { Use(); });

    }
    void Use()
    {
        if ((GameManager.CurrentCollision == "Boulder") && (GameManager.FoundPickaxe))
        {
            GameManager.ToUpdate = true;
            GameManager.ToBeDestroyed = true;
        }
        else if ((GameManager.CurrentCollision == "IceBoulder") && (GameManager.FoundHammer))
        {
            GameManager.ToUpdate = true;
            GameManager.ToBeDestroyed = true;
        }

        else if ((GameManager.CurrentCollision == "tree") && (GameManager.FoundAxe))
        {
            GameManager.ToUpdate = true;
            GameManager.ToBeDestroyed = true;
        }

    }

  
}
