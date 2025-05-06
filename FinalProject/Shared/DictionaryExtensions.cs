// Credit to Kebechet: https://stackoverflow.com/a/76654797

namespace FinalProject.Shared;

public static class DictionaryExtensions
{
    public static TValue PopValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey keyName) where TKey : notnull
    {
        var value = dictionary[keyName];
        dictionary.Remove(keyName);
        return value;
    }
}