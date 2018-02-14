using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkScript : MonoBehaviour {

    private Button btn;

    void Start()
    {
        btn = GetComponent<Button>();
        btn.GetComponent<Button>().onClick.AddListener(delegate { Talk(); });

    }

    void Talk()
    {
        if (GameManager.CurrentQuest == 5 || GameManager.CurrentQuest == 9)
        {
            GameManager.ToUpdate = true;
            Destroy(GameObject.FindGameObjectWithTag("ItemUI"));
        }
    }
}
