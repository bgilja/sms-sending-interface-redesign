# Key redesign decisions and notes

### Vertical Sidebar Navigation

Implemented a collapsible vertical sidebar.
Purpose: Keeps the main content centered and uncluttered.

### Split Compose View

Message composition and user selection are grouped in one section.
Message preview has its own section to maintain clarity and focus.

### Toggleable Message Preview

"Show Preview" switch added.
Delays rendering the preview until explicitly requested, allowing users to focus on composition first.

### Separate User and Group Selection

Users now choose between "Users" and "Groups" using separate dropdowns.
Tradeoff: Can send to only one type at a time, but enhances preview and future flexibility.

### Merged User Properties via Buttons

User-specific dynamic fields are now added using buttons above the message input area.
Reduces typing errors and improves usability.

### Enhanced Input Hints/Info Text

Supporting text below the input is now split into two lines.
Provides more comprehensive information and guidance without clutter.

### Template Selection Feature

Users can select from pre-defined message templates.
Speeds up the process and ensures consistency.

### User-Specific Message Previews

While previewing, users can see how the message looks for each user in the selected criteria (either users or groups).
Allows for quick validation of message tailoring.

### Styled Message Preview

Message preview is displayed in a beige container.
Merged properties or dynamic data are highlighted in red for clear identification.

### Clear Button for Discarding Composed Message

Added a "Clear" button.
Allows users to discard the message composition along with the selected users or groups.

### uccess Notification on Sending

A success notification appears after clicking the "Send" button.
Notification includes the total number of users to receive the message.
