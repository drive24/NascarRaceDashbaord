using Microsoft.AspNetCore.Components;

namespace ui.Components.Organisms;

public partial class ContainerFluid
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}   