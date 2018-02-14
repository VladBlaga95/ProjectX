namespace QuestSystem
{
    public interface IQuestObjective
    {
        string Title { get; }
        string Description { get; }
        bool IsComplete { get; }

        string Verb { get; } 

        string Tagg { get; }

        int CurrentAmount { get; }
        int FinalAmount { get; }

        void CheckProgress();
        void UpdateProgress();

    }
}