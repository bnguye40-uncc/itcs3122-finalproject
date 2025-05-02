public interface IFolderItem {
    string Class { get; }
    string Name { get; }
    string Description { get; }
    bool IsSelected { get; set; }
    bool IsFolder { get; }
}