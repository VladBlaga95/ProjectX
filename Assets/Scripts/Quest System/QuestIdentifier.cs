using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace QuestSystem
{
    public class QuestIdentifier : IQuestIdentifier
    {
        private int chainquestid;
        private int questid;
        private int sourceid;
       

        public QuestIdentifier(int chainquestid, int questid, int sourceid)
        {
            this.chainquestid = chainquestid;
            this.questid = questid;
            this.sourceid = sourceid;
        }

        public int ChainquestID
        {
            get
            {
                return chainquestid;
            }
        }

        public int QuestID
        {
            get
            {
                return questid;
            }
        }

        public int SourceID
        {
            get
            {
                return sourceid;
            }
        }
    }
}