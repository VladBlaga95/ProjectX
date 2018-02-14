using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace QuestSystem
{
    public class QuestInformation : IQuestInformation
    {
        private string name;
        private string description;
       

        public QuestInformation(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

       
        } 
   }
    