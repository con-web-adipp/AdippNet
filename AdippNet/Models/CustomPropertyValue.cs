namespace AdippNet.Models;

public class CustomPropertyValue
{
    public string Key { get; set; } = string.Empty;
    public List<KeyValuePair<int, string>> Value { get; set; }
}