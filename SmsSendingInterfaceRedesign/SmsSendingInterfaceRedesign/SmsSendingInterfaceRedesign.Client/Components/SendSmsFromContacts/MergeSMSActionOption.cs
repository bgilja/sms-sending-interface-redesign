namespace SmsSendingInterfaceRedesign.Client.Components.SendSmsFromContacts;

public sealed class MergeSMSActionOption(string name, string propertyName, UserPropertySelector propertySelector)
{
    public string Name { get; set; } = name;
    public string PropertyName { get; set; } = propertyName;
    public UserPropertySelector PropertySelector { get; } = propertySelector;
}
