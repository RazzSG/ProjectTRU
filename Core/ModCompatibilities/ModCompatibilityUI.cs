using System.Reflection;
using System.Threading.Tasks;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.UI;
using Terraria.UI;

namespace CalamityRuTranslate.Core.ModCompatibilities;

public class ModCompatibilityUI : UIState
{
    public string ModToUpdate { get; internal set; }
    
    private UIPanel _mainUIPanel;
    private readonly UIButton<string>[] _actionButtons = new UIButton<string>[2];
    private UIText _warningUIText;

    public override void OnInitialize()
    {
        _mainUIPanel = new UIPanel();
        _mainUIPanel.Width.Set(700f, 0f);
        _mainUIPanel.Height.Set(180f, 0f);
        _mainUIPanel.BackgroundColor = UICommon.MainPanelBackground;

        _warningUIText = new UIText("");
        _warningUIText.Top.Set(5f, 0f);
        _warningUIText.Left.Set(5f, 0f);
        
        _actionButtons[0] = CreateButton("Закрыть и продолжить", new Vector2(5f, 110f), CloseAndContinue);
        _actionButtons[1] = CreateButton("Перейти в браузер модов", new Vector2(485f, 110f), OpenModBrowser);
        
        foreach (UIButton<string> button in _actionButtons)
            _mainUIPanel.Append(button);
        
        _mainUIPanel.Append(_warningUIText);
        Append(_mainUIPanel);
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        _mainUIPanel.Left.Pixels = (Main.screenWidth - 700f) / 2f;
        _mainUIPanel.Top.Pixels = (Main.screenHeight - 180f) / 2f;
        _mainUIPanel.Recalculate();
        
        string wrappedText = FontAssets.MouseText.Value.CreateWrappedText(_warningUIText.Text, 780f);
        _warningUIText.SetText(wrappedText);
        
        base.Draw(spriteBatch);
    }

    public void SetWarningText(string text)
    {
        _warningUIText?.SetText(text);
    }
    
    private UIButton<string> CreateButton(string text, Vector2 position, MouseEvent clickAction)
    {
        var button = new UIButton<string>(text)
        {
            Width = { Pixels = 180f },
            Height = { Pixels = 40f },
            Left = { Pixels = position.X },
            Top = { Pixels = position.Y }
        };
        button.OnLeftClick += clickAction;
        button.OnMouseOver += (_, _) => SoundEngine.PlaySound(SoundID.MenuTick);
        return button;
    }
    
    private void CloseAndContinue(UIMouseEvent evt, UIElement listeningElement)
    {
        SoundEngine.PlaySound(SoundID.MenuClose);
        ModContent.GetInstance<ModCompatibilityChecker>().CompatibilityUIManager.SetState(null);
    }

    private void OpenModBrowser(UIMouseEvent evt, UIElement listeningElement)
    {
        SoundEngine.PlaySound(SoundID.MenuClose);
        
        Main.RunOnMainThread(() =>
        {
            Main.menuMode = 10;
            Main.gameMenu = true;
            WorldGen.SaveAndQuit();
        });
        
        Main.OnPostDraw += WaitForMenuTransitionThenOpenBrowser;
    }
    
    private void WaitForMenuTransitionThenOpenBrowser(GameTime gameTime)
    {
        if (Main.menuMode == 10)
            return;
        
        Main.OnPostDraw -= WaitForMenuTransitionThenOpenBrowser;

        Main.RunOnMainThread(() =>
        {
            Main.menuMode = 10007;
            
            Assembly tmlAssembly = typeof(ModLoader).Assembly;
            object modBrowserInstance = tmlAssembly.GetType("Terraria.ModLoader.UI.Interface").GetMemberValue<object>("modBrowser");
            object filterTextBoxInstance = modBrowserInstance?.GetMemberValue<object>("FilterTextBox");
            filterTextBoxInstance?.SetMemberValue("Text", "");
            filterTextBoxInstance?.SetMemberValue("Text", ModToUpdate);
        });
    }
}