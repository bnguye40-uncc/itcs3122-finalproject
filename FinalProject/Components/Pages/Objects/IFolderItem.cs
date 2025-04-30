public interface IFolderItem {
    string Class { get; }
    string Name { get; }
    string Description { get; }
    bool IsFolder { get; }
}