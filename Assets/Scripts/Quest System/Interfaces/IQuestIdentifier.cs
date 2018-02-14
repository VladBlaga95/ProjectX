using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace QuestSystem
{
    public interface IQuestIdentifier
    {
        int SourceID { get; }
        int ChainquestID { get; }
        int QuestID { get; }

    }
}