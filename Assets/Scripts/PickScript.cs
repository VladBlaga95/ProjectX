using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickScript : MonoBehaviour {

    private Button btn;
    void Start()
    {
        btn = GetComponent<Button>();
        btn.GetComponent<Button>().onClick.AddListener(delegate { Pick(); });
    
    }
    void Pick()
    {
        if (GameManager.CurrentCollision == "pickaxe")
            GameManager.FoundPickaxe = true;
        if (GameManager.CurrentCollision == "axe")
            GameManager.FoundAxe = true;
        if (GameManager.CurrentCollision == "hammer")
            GameManager.FoundHammer = true;
        if (GameManager.CurrentCollision == "ruby" || GameManager.CurrentCollision == "ankh" || GameManager.CurrentCollision == "pickaxe" || GameManager.CurrentCollision == "axe" || GameManager.CurrentCollision == "shard" || GameManager.CurrentCollision == "hammer")
        {
            GameManager.inv.CreateIcon();
            GameManager.ToUpdate = true;
            GameManager.ToBeDestroyed = true;
        }
         
    }
}
