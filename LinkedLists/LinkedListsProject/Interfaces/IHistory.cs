namespace LinkedListsProject.Interfaces
{
    public interface IHistory
    {
        int DeletedLength { get; }

        void ClearDeleted();
    }

}