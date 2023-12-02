using System.Threading.Tasks;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Microsoft.Xna.Framework;
using ReLogic.Content;
using ReLogic.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.Loaders;

public class TerrariaFontsLoader : ModSystem
{
    private TaskCompletionSource<bool> _unloadTCS;
    private bool _hasBackups;
    private Asset<DynamicSpriteFont>[] _combatTextBackup;
    private Asset<DynamicSpriteFont> _deathTextBackup;
    private Asset<DynamicSpriteFont> _itemStackBackup;
    private Asset<DynamicSpriteFont> _mouseTextBackup;
    
    public override bool IsLoadingEnabled(Mod mod)
    {
        return TRuConfig.Instance.NewRussianTerrariaFont && TranslationHelper.IsRussianLanguage;
    }

    public override void Load()
    {
        if (Main.dedServ)
            return;

        _combatTextBackup = FontAssets.CombatText;
        _deathTextBackup = FontAssets.DeathText;
        _itemStackBackup = FontAssets.ItemStack;
        _mouseTextBackup = FontAssets.MouseText;
        _hasBackups = true;

        FontAssets.ItemStack = Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/Item_Stack", AssetRequestMode.ImmediateLoad);
        FontAssets.MouseText = Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/Mouse_Text", AssetRequestMode.ImmediateLoad);
        FontAssets.DeathText = Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/Death_Text", AssetRequestMode.ImmediateLoad);
        FontAssets.CombatText = new[]
        {
            Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/Combat_Text", AssetRequestMode.ImmediateLoad),
            Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/Combat_Crit", AssetRequestMode.ImmediateLoad)
        };

        Main.OnPreDraw += PreDraw;
    }

    public override void Unload()
    {
        if (!Main.dedServ)
        {
            _unloadTCS = new TaskCompletionSource<bool>();
            _unloadTCS.Task.Wait();
            Main.OnPreDraw -= PreDraw;
        }
    }

    private void PreDraw(GameTime obj)
    {
        if (_unloadTCS != null)
        {
            UnloadFonts();
            _unloadTCS.SetResult(true);
            _unloadTCS = null;
        }
    }

    private void UnloadFonts()
    {
        if (_hasBackups)
        {
            FontAssets.CombatText = _combatTextBackup;
            FontAssets.DeathText = _deathTextBackup;
            FontAssets.ItemStack = _itemStackBackup;
            FontAssets.MouseText = _mouseTextBackup;
            _combatTextBackup = null;
            _deathTextBackup = null;
            _itemStackBackup = null;
            _mouseTextBackup = null;
            _hasBackups = false;
        }
    }
}