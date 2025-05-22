using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Leagueoflegends.Support.UI.Units;

public class RiotSlider : Slider
{
    public RiotSlider()
    {
        DefaultStyleKey = typeof(RiotSlider);
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();

        Thumb thumb = (Thumb)GetTemplateChild("HorizontalThumb");
        thumb.DragStarted += Thumb_DragStarted;
    }

    private void Thumb_DragStarted(object sender, DragStartedEventArgs e)
    {
        VisualStateManager.GoToState(this, "Pressed", true);
    }
}