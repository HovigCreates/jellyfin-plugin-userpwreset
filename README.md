# Jellyfin User Password Reset Plugin

A simple but powerful Jellyfin admin plugin that allows administrators to list users and reset their passwords directly from the web dashboard.

> **⚠️ COMMUNITY NOTICE:**  
> This plugin is developed by a hobbyist developer (**HovigCreates**) to fill a functional gap in Jellyfin's user management.  
> **This plugin is NOT security audited and comes with no warranty.**  
> The community is explicitly invited to review the code, report issues, and contribute improvements via Pull Requests. Use at your own risk.

## Features

- **Admin interface:** Appears directly in the Jellyfin Dashboard under the Plugins section for convenient access by server administrators.
- **User overview:** Displays all Jellyfin users, including clear indicators for admin versus regular accounts to avoid mistakes.
- **Instant password reset:** Generates a new random 12-character password and updates it via the Jellyfin API in a single action.
- **Clipboard-friendly workflow:** Provides a dedicated copy button designed to work reliably even when the Jellyfin dashboard is served over plain HTTP.  
- **Native look & feel:** Uses Jellyfin's existing UI components and user avatars so the plugin blends seamlessly into the existing dashboard design.

## Installation

### Via Plugin Repository (Recommended)

1. Open Jellyfin Dashboard → Plugins → Repositories
2. Add this repository URL: `https://raw.githubusercontent.com/HovigCreates/jellyfin-plugin-userpwreset/master/manifest.json`
3. Go to Catalog, search for "User Password Reset"
4. Click Install and restart Jellyfin

### Manual Installation

1. Download the latest `.zip` or `.dll` from the [Releases](https://github.com/HovigCreates/jellyfin-plugin-userpwreset/releases) section
2. Extract/copy into your Jellyfin plugins directory:  
   - **Linux:** `/var/lib/jellyfin/plugins/UserPasswordReset/`
   - **Windows:** `C:\ProgramData\Jellyfin\Server\plugins\UserPasswordReset\`
3. Restart Jellyfin

### Build from Source

```bash
git clone https://github.com/HovigCreates/jellyfin-plugin-userpwreset.git
cd jellyfin-plugin-userpwreset/Jellyfin.Plugin.Template
dotnet publish -c Release
Copy contents of bin/Release/net9.0/publish/ to your Jellyfin plugins directory and restart.

How It Works
Dashboard integration: The plugin registers a configuration page in the Jellyfin admin dashboard

Password generation: Secure random 12-character passwords are generated client-side in the browser

API compatibility: Uses both legacy NewPw and modern NewPassword fields for maximum compatibility

Secure distribution: New passwords are displayed only to the admin performing the reset

Compatibility
Jellyfin Version: 10.9.11 or newer

Framework: .NET 9.0

Contributing
Code review welcome: Experienced .NET and Jellyfin developers are explicitly invited to audit the implementation

Issues: Report problems and enhancement ideas via GitHub Issues

Pull Requests: Contributions for security improvements, refactoring, or new features are highly appreciated

Support
If you find this plugin useful and would like to support charitable work, consider visiting AGBU Germany - a non-profit organization supporting the Armenian community.

License
Licensed under GNU General Public License v3.0 (GPLv3).

You may copy, distribute, and modify the software, provided that:

Source files track changes and dates

Modified versions are also released under GPLv3 with build instructions

See LICENSE file or visit https://www.gnu.org/licenses/gpl-3.0.txt
