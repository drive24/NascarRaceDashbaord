using Microsoft.AspNetCore.Components;

namespace ui.Components.Molecules;

public partial class ListItem
{
    [Parameter]
    public string[] Classes { get; set; } = Array.Empty<string>();
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    private string _classes { get; set; } = string.Empty;

    protected override void OnInitialized()
    {
        _classes = string.Join(" ", Classes.Append("list-group-item"));
    }
}