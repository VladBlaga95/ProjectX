using System.Collections.Generic;
using UnityEngine;
namespace QuestSystem
{
    public class Quest
    {

        private List<IQuestObjective> objective;
        private IQuestInformation text;
        private IQuestIdentifier ident;

        public Quest(string QuestName,string Story,int QuestID,int PreviosQuestID,string VerbMission,int HowManyToCollect,GameObject TypeToCollect,string Description,string Tag)
        {
            text = new QuestInformation(QuestName, Story);
            ident = new QuestIdentifier(PreviosQuestID,QuestID,0);
            objective = new List<IQuestObjective>();
            objective.Add(new CollectionObjective(VerbMission,HowManyToCollect,TypeToCollect,Description,Tag));
        }
        public void AddExtraObjective(string VerbMission, int HowManyToCollect, GameObject TypeToCollect, string Description,string Tag)
        {
            objective.Add(new CollectionObjective(VerbMission, HowManyToCollect, TypeToCollect, Description,Tag));
        }
        public IQuestInformation GetQuestInform()
        {
            return text;
        }
        public List<IQuestObjective> GetQuestObj()
        {
            return objective;
        }
        public IQuestIdentifier GetQuestIdent()
        {
            return ident;
        }
    }
}