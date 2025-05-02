public interface IFolderItem {
    string Class { get; set; }
    string Name { get; set; }
    string Description { get; set; }
    bool IsSelected { get; set; }
    bool IsFolder { get; }
}