using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestSystem;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {



    private GameObject gobj;
    private GameObject go;
    private GameObject GetTxt;
    private GameObject GetDesc;
    private GameObject GetObj;
    private IQuestInformation qtxt;
    private List<IQuestObjective> qobj;
    private Button but;
    int counter;
    public void Start()
    {
        gobj = GameObject.FindGameObjectWithTag("QuestPanel");
        go = GameObject.FindGameObjectWithTag("QuestPanel");
        GetTxt = GameObject.FindGameObjectWithTag("QuestTitle");
        GetDesc = GameObject.FindGameObjectWithTag("QuestDesc");
        GetObj = GameObject.FindGameObjectWithTag("QuestObjective");
        but = GetComponent<Button>();
        but.GetComponent<Button>().onClick.AddListener(delegate { Hide(); });
        gobj.gameObject.SetActive(false);

    }

    public void Awake()
    {
      

    }

    public void Hide()
    {
        counter++;
        if (counter % 2 == 0)
            gobj.gameObject.SetActive(false);
        else
            gobj.gameObject.SetActive(true);
        AddText();
    }

    public void Update()
    {
        AddText();
    }

    public void AddText()
    {
        int index = GameManager.CurrentQuest;

        Text Qtitle = GetTxt.GetComponent<Text>();
        Text Qdesc = GetDesc.GetComponent<Text>();

        qtxt = GameManager.Quests[index].GetQuestInform();
        qobj = GameManager.Quests[index].GetQuestObj();

        Qtitle.text = qtxt.Name;
        Qdesc.text = qtxt.Description;

        GetTxt.GetComponent<Text>().text = Qtitle.text;
        GetDesc.GetComponent<Text>().text = Qdesc.text;

        GetObj.GetComponent<Text>().text = qobj[0].Verb + " "+ qobj[0].CurrentAmount + "/" + qobj[0].FinalAmount + " " + qobj[0].Description;
        
        
        
    }
}
