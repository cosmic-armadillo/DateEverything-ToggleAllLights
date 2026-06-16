![Header Image](/images/HeaderImage.png)

# Toggle All Lights - A mod for Date Everything! <!-- omit from toc -->

Turn all the lights in the house on or off at the same time by pressing configurable keyboard hotkeys!

⭐ See [Releases](https://github.com/cosmic-armadillo/DateEverything-ToggleAllLights/releases) to download the mod, or alternatively, you can download it from [Nexus Mods](https://www.nexusmods.com/dateeverything/mods/23).

<small>_I got sick of having to turn lights on in each room once night came around, so decided to build this quick mod to solve that._</small>

## Contents <!-- omit from toc -->

- [Requirements](#requirements)
- [Installation instructions](#installation-instructions)
- [Configuration](#configuration)
- [Problems/Troubleshooting](#problemstroubleshooting)

## Requirements

- [BepInEx 5.4.23](https://github.com/BepInEx/BepInEx/releases)
- [BepInEx Configuration Manager](https://github.com/BepInEx/BepInEx.ConfigurationManager/releases) - _optional, but recommended_

## Installation instructions

1. Make sure you have run the game at least once after installing [BepInEx](https://github.com/BepInEx/BepInEx/releases).
2. Extract the zip file and drag `ToggleAllLights-v1.0.0.dll` to the plugins folder - typically at `"...\Date Everything\BepInEx\plugins"`
    - (on Steam, you can right click the game and select "Manage > Browse Local Files")

## Configuration

You can configure the hotkeys via the [BepInEx Configuration Manager](https://github.com/BepInEx/BepInEx.ConfigurationManager/releases), or you can edit them manually via `"...\BepInEx\config\ToggleAllLights.cfg"` (make sure to check the [Unity KeyCodes](https://docs.unity3d.com/6000.4/Documentation/ScriptReference/KeyCode.html) reference info).

- **Enabled:** Enables/disables the mod..... obviously.... _(Default: `true`)_
- **Toggle All Lights Off:** Sets the desired keyboard hotkey to toggle all lights off _(Default: `Minus`)_
- **Toggle All Lights On:** Sets the desired keyboard hotkey to toggle all lights on _(Default: `Equals`)_
- **Debug Mode:** Enables/disables Debug Mode, which is logs extra info to the console. Helpful if something isn't working properly _(Default: `false`)_

![Config Image](/images/ConfigImage.png "The in-game config panel when using the BepInEx Configuration Manager")<small>_<br>^ The in-game config panel when using the BepInEx Configuration Manager._</small>

## Problems/Troubleshooting

If something isn't working right, please follow these steps to help me to help you:

- Double check that the mod is enabled via the [BepInEx Configuration Manager](https://github.com/BepInEx/BepInEx.ConfigurationManager/releases) or directly in `ToggleAllLights.cfg`
- Enable **Debug Mode** in that same config
- In game, press the hotkey assigned to toggle ON a couple times
- Then, press the hotkey assigned to toggle OFF a couple times
- Exit the game, then find the `LogOutput.log` file in the BepInEx folder, typically at `"...\Date Everything\BepInEx\"`
- Attach a copy of the log file to a **bug report** which you can submit via the [Issues](https://github.com/cosmic-armadillo/DateEverything-ToggleAllLights/issues) tab on Github or via the [Bugs tab on Nexus Mods](https://www.nexusmods.com/dateeverything/mods/23?tab=bugs).

<br>

---

<br>

<small>_I'm still pretty new to modding so I welcome any suggestions or feedback!  
I hope this mod makes this one tiny aspect of dating your household furniture slightly less tedious...  
– Cosmic_ ❤</small>
