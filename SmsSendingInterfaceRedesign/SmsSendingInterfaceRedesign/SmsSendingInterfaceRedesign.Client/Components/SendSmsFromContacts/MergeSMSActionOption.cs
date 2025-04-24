namespace SmsSendingInterfaceRedesign.Client.Components.SendSmsFromContacts;

public sealed class MergeSMSActionOption(string name, string propertyName)
{
    public string Name { get; set; } = name;
    public string PropertyName { get; set; } = propertyName;
}
