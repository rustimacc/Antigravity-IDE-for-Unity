# Setup Antigravity on Windows

1. Ensure Antigravity IDE is installed on your Windows machine.
2. In Unity, go to **Edit > Preferences > External Tools**.
3. Under the **External Script Editor** dropdown, look for **Antigravity**.
   - If Antigravity is not in the list, you can manually locate the executable by clicking **Browse...** in the dropdown.
   - Point the file browser to `Antigravity.exe`.
4. Ensure the checkboxes for **Generate .csproj files for:** are ticked appropriately for your project's needs (e.g. Local tarball, embedded packages, local packages).
5. Click **Regenerate project files** to create your `.sln` and `.csproj` items.

You're done! Double-clicking `.cs` scripts in Unity will now open Antigravity IDE.
