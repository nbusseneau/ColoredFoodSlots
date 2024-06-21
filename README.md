# Colored Food UI

Very simple [Valheim](https://store.steampowered.com/app/892970/Valheim/) mod that colors food UI backgrounds based on their dominant stat. Client-side, no configuration.

## But why?

**Colored Food UI** helps you visualize your diet mix at a glance so you can easily know what's running out soon or what's missing based on recognizable colored backgrounds.
It uses the exact same colors as the ones used by Valheim for the fork symbol displayed on food icons in the inventory:

- **Red**: health-dominant
- **Yellow**: stamina-dominant
- **Blue**: eitr-dominant
- **White**: mixed

### Compatibility with other mods

**Colored Food UI** recolors the vanilla food UI backgrounds and will conflict with any UI mod that touches them.
It should work transparently with everything else, including mods that add new food items.
Feel free to [report any issue you find](https://github.com/nbusseneau/BetterCartographyTable/issues/new).

## Install

This is a client-side mod.
If installed on the server, it will do nothing.

### Thunderstore (recommended)

- **[Prerequisite]** Install [**r2modman**](https://thunderstore.io/c/valheim/p/ebkr/r2modman/).
- Click **Install with Mod Manager** from the [mod page](https://thunderstore.io/c/valheim/p/nbusseneau/Colored_Food_UI/).

### Manually (not recommended)

- **[Prerequisites]**
  - Install [**BepInExPack Valheim**](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/).
- Download [nbusseneau-Colored_Food_UI-0.0.1.zip](https://github.com/nbusseneau/ColoredFoodUI/releases/latest/download/nbusseneau-Colored_Food_UI-0.0.1.zip).
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

### Special thanks

**Colored Food UI** is a reimplementation of a mod initially created by [warpalicious](https://thunderstore.io/c/valheim/p/warpalicious/).
Check out their POI content mods, you won't regret it 👍
