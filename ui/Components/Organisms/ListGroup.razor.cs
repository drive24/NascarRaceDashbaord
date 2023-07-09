using Microsoft.AspNetCore.Components;

namespace ui.Components.Organisms;

public partial class ListGroup
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}