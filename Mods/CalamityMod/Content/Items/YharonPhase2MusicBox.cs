using CalamityRuTranslate.Common;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.Content.Items;

public class YharonPhase2MusicBox : ModItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity != null;
    }
    
    public override void SetStaticDefaults()
    {
        ItemID.Sets.CanGetPrefixes[Type] = false;
        ItemID.Sets.ShimmerTransformToItem[Type] = ItemID.MusicBox;
        
        MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Assets/Sounds/Music/Calamity/YharonPhase2"), ModContent.ItemType<YharonPhase2MusicBox>(), ModContent.TileType<Tiles.YharonPhase2MusicBox>());
    }
    
    public override void SetDefaults()
    {
        Item.DefaultToMusicBox(ModContent.TileType<Tiles.YharonPhase2MusicBox>());
    }
}