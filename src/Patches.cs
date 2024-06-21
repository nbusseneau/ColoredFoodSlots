using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace ColoredFoodUI;

public class Patches
{
  private const float Alpha = 0.503f; // vanilla food slot alpha value
  private static Color s_healthColor;
  private static Color s_staminaColor;
  private static Color s_eitrColor;
  private static Color s_mixedColor;
  private static Color s_defaultColor;

  private static Color InitializeColor(Color color, float alpha = Alpha) => new(color.r, color.g, color.b, alpha);

  [HarmonyPostfix]
  [HarmonyPatch(typeof(InventoryGui), nameof(InventoryGui.Awake))]
  private static void InitializeColors(InventoryGui __instance)
  {
    // set our colors combining vanilla food icon colors with vanilla food slot alpha value
    s_healthColor = InitializeColor(__instance.m_playerGrid.m_foodHealthColor);
    s_staminaColor = InitializeColor(__instance.m_playerGrid.m_foodStaminaColor);
    s_eitrColor = InitializeColor(__instance.m_playerGrid.m_foodEitrColor);
    s_mixedColor = InitializeColor(Color.white);
    s_defaultColor = InitializeColor(Color.black);
  }

  [HarmonyPostfix]
  [HarmonyPatch(typeof(Hud), nameof(Hud.UpdateFood))]
  private static void UpdateFood(Hud __instance, Player player)
  {
    var foods = player.GetFoods();
    var foodIcons = __instance.m_foodIcons;

    for (int i = 0; i < foodIcons.Length; i++)
    {
      var foodBackground = foodIcons[i].transform.parent.gameObject.GetComponent<Image>();
      if (i < foods.Count && foods[i] is { } food)
      {
        // use the exact same logic as for vanilla food icon colors from InventoryGrid.UpdateGui(...)
        if (food.m_eitr / 2f > food.m_health && food.m_eitr / 2f > food.m_stamina) foodBackground.color = s_eitrColor;
        else if (food.m_health / 2f > food.m_stamina) foodBackground.color = s_healthColor;
        else if (food.m_stamina / 2f > food.m_health) foodBackground.color = s_staminaColor;
        else foodBackground.color = s_mixedColor;
      }
      else foodBackground.color = s_defaultColor;
    }
  }
}
