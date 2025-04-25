namespace SmsSendingInterfaceRedesign.Client.Components.SendSmsFromContacts;

public sealed class MergeSMSTemplate(string name, string messageTemplate)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name { get; } = name;
    public string MessageTemplate { get; } = messageTemplate;
}
