using CalamityRuTranslate.Common;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.ObjectInteractions;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Utilities;

namespace CalamityRuTranslate.Mods.CalamityMod.Content.Tiles;

public class YharonPhase2MusicBox : ModTile
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity != null;
    }
    
    public override void SetStaticDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileObsidianKill[Type] = true;
        TileID.Sets.DisableSmartCursor[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
        TileObjectData.newTile.Origin = new Point16(0, 1);
        TileObjectData.newTile.LavaDeath = false;
        TileObjectData.newTile.DrawYOffset = 2;
        TileObjectData.newTile.StyleLineSkip = 2;
        TileObjectData.addTile(Type);
        AddMapEntry(new Color(191, 142, 111), Language.GetText("ItemName.MusicBox"));
    }

    public override void MouseOver(int i, int j)
    {
        Player localPlayer = Main.LocalPlayer;
        localPlayer.noThrow = 2;
        localPlayer.cursorItemIconEnabled = true;
        localPlayer.cursorItemIconID = ModContent.ItemType<Items.YharonPhase2MusicBox>();
    }

    public override bool CreateDust(int i, int j, ref int type)
    {
        return false;
    }

    public override bool HasSmartInteract(int i, int j, SmartInteractScanSettings settings)
    {
        return true;
    }
    
    public override void PostDraw(int i, int j, SpriteBatch spriteBatch)
    {
        Tile tile = Framing.GetTileSafely(i, j);
        
        if (!TileDrawing.IsVisible(tile))
            return;
        
        Vector2 zero = new(Main.offScreenRange, Main.offScreenRange);
        
        if (Main.drawToScreen)
            zero = Vector2.Zero;

        int height = tile.TileFrameY == 36 ? 18 : 16;
        Main.spriteBatch.Draw(ModContent.Request<Texture2D>(Texture + "_Glow").Value, new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero, new Rectangle(tile.TileFrameX, tile.TileFrameY, 16, height), Color.White, 0f, Vector2.Zero, 1f, 0, 0f);

        spriteBatch.End();
        spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, Main.DefaultSamplerState, DepthStencilState.None, RasterizerState.CullNone, null);
    }
    
    public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref TileDrawInfo drawData)
    {
        if (Main.gamePaused || !Main.instance.IsActive || (Lighting.UpdateEveryFrame && new FastRandom(Main.TileFrameSeed).WithModifier(i, j).Next(4) != 0))
            return;
        
        Tile tile = Main.tile[i, j];
        
        if (!TileDrawing.IsVisible(tile) || tile.TileFrameX != 36 || tile.TileFrameY % 36 != 0 || (int)Main.timeForVisualEffects % 7 != 0 || !Main.rand.NextBool(3)) {
            return;
        }

        int musicNote = Main.rand.Next(570, 573);
        Vector2 spawnPosition = new Vector2(i * 16 + 8, j * 16 - 8);
        Vector2 noteMovement = new Vector2(Main.WindForVisuals * 2f, -0.5f);
        noteMovement.X *= Main.rand.NextFloat(0.5f, 1.5f);
        noteMovement.Y *= Main.rand.NextFloat(0.5f, 1.5f);
        switch (musicNote) {
            case 572:
                spawnPosition.X -= 8f;
                break;
            case 571:
                spawnPosition.X -= 4f;
                break;
        }

        Gore.NewGore(new EntitySource_TileUpdate(i, j), spawnPosition, noteMovement, musicNote, 0.8f);
    }
}