using BepInEx;
using HarmonyLib;

namespace ColoredFoodUI;

[BepInPlugin(ModGUID, ModName, ModVersion)]
public class Plugin : BaseUnityPlugin
{
  private const string ModGUID = "nbusseneau.ColoredFoodUI";
  private const string ModName = "ColoredFoodUI";
  private const string ModVersion = "0.2.1";

  public void Awake()
  {
    Harmony harmony = new(ModGUID);
    harmony.PatchAll(typeof(Patches));
  }
}
