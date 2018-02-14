using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestSystem;
using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class GameManager: MonoBehaviour
{
    static GameManager Instance;
    public static int level=1;
    public static Transform trans;
    public static List<Quest> Quests;
    private static GameObject gameitem;
    public static int CurrentQuest=0;
    public static Inventory inv;
    public static string CurrentCollision;

    public static bool isUsed   = false;
    public static bool ToUpdate = false;
    public static bool ToBeDestroyed = false;

    public static bool FoundPickaxe = false;
    public static bool FoundAxe = false;
    public static bool FoundHammer = false;

    public static bool CurrentQComplete =false;

    public static bool isPortalGenerated = false;
    //public static Action func;

    public static GameObject temp;
     void Start()
    {
        inv = new Inventory();
    }

    void Update()
    {
#if UNITY_EDITOR

        if (CurrentQuest == 2 && !isPortalGenerated)
        {
            Instantiate(AssetDatabase.LoadAssetAtPath("Assets/Prefabs/DesertPortal.prefab", typeof(GameObject)), new Vector3(-4879.32f, 3297.68f , -1668.68f), Quaternion.identity);
            isPortalGenerated = true;
        }
        if (CurrentQuest == 6 && isPortalGenerated)
        {
            Instantiate(AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Forest Portal.prefab", typeof(GameObject)), new Vector3(-5158.6f, 3326.6f, -2112.9f), Quaternion.identity);
            isPortalGenerated = false;
        }
        if (CurrentQuest == 10 && !isPortalGenerated)
        {
            Instantiate(AssetDatabase.LoadAssetAtPath("Assets/Prefabs/IcePortal.prefab", typeof(GameObject)), new Vector3(-5800.1f, 4606.1f, -1852.196f), Quaternion.identity);
            isPortalGenerated = true;
        }
        if (CurrentQuest == 14 && isPortalGenerated)
        {
            Instantiate(AssetDatabase.LoadAssetAtPath("Assets/Prefabs/CityPortal.prefab", typeof(GameObject)), new Vector3(-5567.325f, 3680.697f,-2646.88f), Quaternion.identity);
            isPortalGenerated = false;
        }
        if (CurrentQuest == 15 && isPortalGenerated)
        {
            Instantiate(AssetDatabase.LoadAssetAtPath("Assets/Prefabs/MayanPortal.prefab", typeof(GameObject)), new Vector3(-5949.4f, 6684.407f, -3916.314f), Quaternion.identity);
            isPortalGenerated = false;
        }
#endif
        if (ToBeDestroyed)
        {
            ToBeDestroyed = false;
            Destroy(GameObject.FindGameObjectWithTag("ItemUI"));
            Destroy(temp);
        }
             
        if (ToUpdate)
        {
            StatusUpdate();
            ToUpdate = false;
               
        }

        if (CurrentQComplete)
        {
            StartCoroutine(Waitalittle());
            CurrentQComplete = false;
        }
    }

    public void Awake()
    {
        if (Instance != null)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        Quests = new List<Quest>();
        gameitem = new GameObject();
        inv = new Inventory();
        Quests.Add(new Quest("Welcome to the Mineshaft", "An adventurer lost his legendary pickaxe.", 0, 0, "Search", 1, gameitem, "which  can be found in one of the rooms!", "pickaxe"));
        Quests.Add(new Quest("The Cursed Boulders", "There are 7 boulders that block your way to the next level.", 0, 0, "Destroy", 7, gameitem, "and open the portal","Boulder"));
        Quests.Add(new Quest("Desert Portal", "You raised the cursed.", 0, 0, "Find", 1, gameitem, "portal", "Portal"));
        Quests.Add(new Quest("Welcome to the Ancient Egypt", "A Paraoh lost his ruby.", 0, 0, "Collect", 2, gameitem, " ruby .", "ruby"));
        Quests.Add(new Quest("Ancient Relic!", "The symbol of immortality , Ankh was lost!.", 0, 0, "Find", 1, gameitem, " ankh and talk to the Paraoh.", "ankh"));
        Quests.Add(new Quest("The Paraoh!", "As a graditude paraoh open the portal for you !", 0, 0, "Talk to paraoh", 1, gameitem, "and open the portal.","Egypt"));
        Quests.Add(new Quest("Bye Bye Egpyt!", "Its time to leave Egypt!.", 0, 0, "Find", 1, gameitem, "portal.", "Portal"));
        Quests.Add(new Quest("Welcome to the Castle!", "The king is blocked in the castle!.", 0, 0, "Find ", 1, gameitem, "axe.", "axe"));
        Quests.Add(new Quest("Get me out of here!", "The trees are blocking the way!", 0, 0, "Destroy", 3, gameitem, "trees.", "tree"));
        Quests.Add(new Quest("Talk to the king!", "Thank you traveler, you can go now!.", 0, 0, "Find", 1, gameitem, "portal.", "Portal"));
        Quests.Add(new Quest("Welcome in Alaska!", "It's so cold.... !", 0, 0, "Find", 1, gameitem, "hammer .", "hammer"));
        Quests.Add(new Quest("You are gettin in my way!", "Break the ice boudler!", 0, 0, "Destroy", 1, gameitem, " the ice boulder.", "IceBoulder"));
        Quests.Add(new Quest("Someting seems broken!", "The portal its broken , FIX IT!", 0, 0, "Find", 2, gameitem, " shards and go to the portal.", "shards"));
        Quests.Add(new Quest("Go and never come back!", "Portal it's spawned!", 0, 0, "Find", 1, gameitem, " portal.", "Portal"));
        Quests.Add(new Quest("Welcome to the Labyrinth City!", "Now this is easy...find the portal.IF YOU CAN!!!.", 0, 0, "Find", 1, gameitem, "portal.", "Portal"));
        Quests.Add(new Quest("Welcome to the Mayan Pyramids!", "Explore and have fun!.", 0, 0, "Explore", 99999, gameitem, ".Be careful not to fall!!!", "Portal"));
    }

    public void StatusUpdate()
    {
        List<IQuestObjective> iqob = Quests[CurrentQuest].GetQuestObj();
    
        foreach (IQuestObjective obj in iqob)
        {

            if (!obj.IsComplete)
            {
                obj.UpdateProgress();
                if (obj.IsComplete)
                    CurrentQComplete = true;
            }
                
                     

         }

       
    }
    
    public IEnumerator Waitalittle()
    {
      
        yield return new WaitForSeconds(3f);
        CurrentQuest++;
    }
   
}


