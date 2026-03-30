# Antigravity IDE Integration for Unity

This package provides native integration for Antigravity IDE within Unity on Windows.

## Features
- Registers Antigravity as an External Script Editor in Unity (`Edit > Preferences > External Tools`).
- Automatically manages .sln and .csproj generation using Unity's built-in behavior.
- Redirects double-clicks on scripts and compilation errors directly to Antigravity.
- Safe execution path validation and fallback mechanics for gracefully opening files even if specific CLI line/col jumps aren't supported.

## Requirements
- Unity 2021.3+
- Windows OS
- Antigravity IDE installed

## Installation
1. Open the Package Manager in Unity (`Window > Package Manager`).
2. Click the `+` icon and choose `Add package from disk...`.
3. Select the `package.json` file inside the `com.ide.antigravity` folder.
4. Go to `Edit > Preferences > External Tools` and select `Antigravity` from the dropdown.

## Troubleshooting
See the `Documentation~` folder for more details inside the package.
