namespace SmsSendingInterfaceRedesign.Client.Components.SendSmsFromContacts;

[AttributeUsage(AttributeTargets.Property)]
public sealed class UserPropertySelectorAttribute(UserPropertySelector selector) : Attribute
{
    public UserPropertySelector Selector { get; } = selector;
}
