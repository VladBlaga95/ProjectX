using UnityEngine;
using System;
namespace QuestSystem
{

    public class CollectionObjective : IQuestObjective
    {

        private string title;
        private string description;
        private int currentAmount;
        private int finalAmount;
        private GameObject gameitem;
        private bool isComplete;
        private string nametag;

        private string verb;
        private string tagg;

        public CollectionObjective(string verb,int totalamount,GameObject item,string descr,string tag)
        {
            title =verb + " " + currentAmount + "/" + totalamount + " " + tag;
            description = descr;
            gameitem = item;
            finalAmount = totalamount;
            currentAmount = 0;
            item.tag = tag;
            this.verb = verb;
            this.tagg = tag;
            isComplete=false;
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
        }

        public int CurrentAmount
        {
            get
            {
                return currentAmount;
            }
        }

        public int FinalAmount
        {
            get
            {
                return finalAmount;
            }
        }

        public GameObject Gameitem
        {
            get
            {
                return gameitem;
            }
        }
        public string NameTag
        {
            get
            {
                return nametag;
            }
        }
        public string Verb
        {
            get
            {
                return verb;
            }
        }

        public string Tagg
        {
            get
            {
                return tagg;
            }
        }    

        public bool IsComplete
        {
            get {
                return isComplete;
            }
        }
        public void CheckProgress()
        {
            if (currentAmount == finalAmount)
            {
                
                this.isComplete = true;
            }
               
            
        }

        public void UpdateProgress()
        {
            
            currentAmount++;
            if (currentAmount>finalAmount)
                currentAmount = finalAmount;
            CheckProgress();
            

        }
    }
}