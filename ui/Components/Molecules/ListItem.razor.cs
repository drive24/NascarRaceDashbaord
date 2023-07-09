using Microsoft.AspNetCore.Components;

namespace ui.Components.Molecules;

public partial class ListItem
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}