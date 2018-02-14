using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QuestSystem;
public class QuestUI : MonoBehaviour {

    private GameObject go;
    private GameObject GetTxt;
    public IQuestInformation qtxt;

    public void AddText()
    {
        go = GameObject.FindGameObjectWithTag("QuestPanel");
        GetTxt = GameObject.FindGameObjectWithTag("Quest Title");
        Text Qtitle = GetTxt.GetComponent<Text>();
        qtxt = GameManager.Quests[0].GetQuestInform();
        Debug.Log("" + qtxt.Name + " " + qtxt.Description);
        Qtitle.text = qtxt.Name;
        GetTxt.GetComponent<Text>().text = Qtitle.text;
    }
}
