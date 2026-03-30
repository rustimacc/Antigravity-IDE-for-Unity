# Troubleshooting

## Antigravity IDE does not appear in the External Script Editor list

If Antigravity is installed in a non-standard location, Unity might not find it automatically.
- Open **Edit > Preferences > External Tools**.
- Click the dropdown and select **Browse...**.
- Manually locate `Antigravity.exe` in your file system.

## Double-clicking a script opens the folder instead of the code

This occurs if the registered path points to the installation directory instead of the executable.
- Ensure you set the path exactly to `Antigravity.exe` and not just its folder.

## Scripts open, but it does not jump to the correct compile error line

The current integration includes fallbacks for jumping to a specific line/column. If the current version of Antigravity CLI does not support routing args (`--line X --column Y`), the fallback system will simply open the requested `.cs` file without navigating directly to the line of error. Future updates to the CLI parser on Antigravity will enable precise code navigation.

## IntelliSense is not working

Ensure Unity has generated the `.sln` and `.csproj` files:
- Go to **Edit > Preferences > External Tools**.
- Click **Regenerate project files**.
- Ensure that the right package scope is selected under "Generate .csproj files for:".
