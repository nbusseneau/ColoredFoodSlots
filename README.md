# Colored Food UI

Very simple [Valheim](https://store.steampowered.com/app/892970/Valheim/) mod that colors food UI backgrounds based on their dominant stat.
Client-side, no configuration.

## Video showcase

https://github.com/nbusseneau/ColoredFoodUI/assets/4659919/73388937-de2b-43f2-94c7-62746b3a599b

## Features

- Food UI backgrounds are colored based on food type:
  - **Red**: health-dominant
  - **Yellow**: stamina-dominant
  - **Blue**: eitr-dominant
  - **White**: mixed
- Uses Valheim's food type colors (the fork symbol displayed on food icons in the inventory).

## But why?

**Colored Food UI** helps you visualize your diet mix at a glance using recognizable colored backgrounds.
You immediately know what type of food is running out soon or what is currently missing, which is particularly helpful when your mix uses food with different durations and they run out in combat at different intervals.

## Compatibility with other mods

**Colored Food UI** recolors the vanilla food UI backgrounds and may conflict with UI mods that change the food UI.
It should work transparently with everything else, including UI mods that do change the food UI and mods that add new food items.
Feel free to [report any issue you find](https://github.com/nbusseneau/ColoredFoodUI/issues/new).

## Install

- This is a client-side mod, and does not need to be installed on the server.
- If installed on the server, it will do nothing.

In other words:

- This mod can be installed on your side as a client, and you will still be able to join any server (even vanilla ones).

### Thunderstore (recommended)

- **[Prerequisite]** Install [**r2modman**](https://thunderstore.io/c/valheim/p/ebkr/r2modman/).
- Click **Install with Mod Manager** from the [mod page](https://thunderstore.io/c/valheim/p/nbusseneau/Colored_Food_UI/).

### Manually (not recommended)

- **[Prerequisites]**
  - Install [**BepInExPack Valheim**](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/).
- Download [nbusseneau-Colored_Food_UI-0.1.0.zip](https://github.com/nbusseneau/ColoredFoodUI/releases/latest/download/nbusseneau-Colored_Food_UI-0.1.0.zip).
- Extract the archive and move everything to your `BepInEx/plugins/` directory. It should look like this:
  ```
  BepInEx/
  └── plugins/
      └── nbusseneau-Colored_Food_UI/
          ├── CHANGELOG.md
          ├── icon.png
          ├── manifest.json
          ├── plugins/
          └── README.md
  ```

## Special thanks

**Colored Food UI** is a reimplementation of a mod initially created by [warpalicious](https://thunderstore.io/c/valheim/p/warpalicious/).
Check out their POI content mods, you won't regret it 👍
