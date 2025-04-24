namespace SmsSendingInterfaceRedesign.Client.Components.Core.Dropdown;

public sealed class DropdownItem(Guid key, string value)
{
    public Guid Key { get; private set; } = key;
    public string Value { get; private set; } = value;

    public override string ToString()
    {
        return Value;
    }
}
