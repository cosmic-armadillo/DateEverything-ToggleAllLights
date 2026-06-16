using BepInEx;
using BepInEx.Configuration;
using UnityEngine;

namespace DateEverything_ToggleAllLights
{
    [BepInPlugin($"ToggleAllLights", "Toggle All Lights", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private ConfigEntry<bool> EnableMod;
        private ConfigEntry<KeyboardShortcut> ToggleOnKey { get; set; }
        private ConfigEntry<KeyboardShortcut> ToggleOffKey { get; set; }
        private ConfigEntry<bool> DebugMode;

        private void Awake()
        {
            EnableMod = Config.Bind(
                "General",
                "Enabled",
                true,
                "Enable or disable the mod. Default: true"
            );

            ToggleOnKey = Config.Bind(
                "Hotkeys",
                "Toggle All Lights On",
                new KeyboardShortcut(KeyCode.Equals),
                "Turns all house lights on. Default: Equals (=)"
            );

            ToggleOffKey = Config.Bind(
                "Hotkeys",
                "Toggle All Lights Off",
                new KeyboardShortcut(KeyCode.Minus),
                "Turns all house lights off. Default: Minus (-)"
            );

            DebugMode = Config.Bind(
                "Debug",
                "Debug Mode",
                false,
                "When enabled, logs extra information that may help with troubleshooting.Keep disabled for general gameplay."
            );

            Logger.LogInfo("ToggleAllLights mod loaded!");
            Logger.LogInfo(
                "\n" +
                "---- ## SETTINGS LOADED ## ----\n" +
                $"  Mod enabled:          {EnableMod.Value}\n" +
                $"  Toggle ON hotkey:     {ToggleOnKey.Value}\n" +
                $"  Toggle OFF hotkey:    {ToggleOffKey.Value}\n" +
                $"  Debug Mode enabled:   {DebugMode.Value}\n" +
                "-------------------------------"
            );

            DebugMode.SettingChanged += (_, _) =>
            {
                Logger.LogInfo($"Debug Mode is now {(DebugMode.Value ? "enabled" : "disabled")}");
            };
        }

        private void Update()
        {
            if (EnableMod.Value == true)
            {
                if (ToggleOnKey.Value.IsDown())
                {
                    if (DebugMode.Value == true)
                    {
                        Logger.LogInfo($"DEBUG - Hotkey press detected: Toggle ON ({ToggleOnKey.Value})");
                    }

                    SetAllLights(true);
                }

                if (ToggleOffKey.Value.IsDown())
                {
                    if (DebugMode.Value == true)
                    {
                        Logger.LogInfo($"DEBUG - Hotkey press detected: Toggle OFF ({ToggleOffKey.Value})");
                    }

                    SetAllLights(false);
                }
            }
        }

        private void SetAllLights(bool state)
        {
            Lights_Inter[] switches = FindObjectsOfType<Lights_Inter>(true);

            Logger.LogInfo($"Toggled {switches.Length} lights {(state ? "on" : "off")}.");

            foreach (Lights_Inter lightSwitch in switches)
            {
                if (lightSwitch == null)
                {
                    continue;
                }

                if (lightSwitch.lightsOn == state)
                {
                    continue;
                }

                // First arg: desired light state
                // Second arg: silent mode (otherwise we would get 171 switch sound effects all play at once lol)
                lightSwitch.Interact(state, true);
            }
        }
    }
}
