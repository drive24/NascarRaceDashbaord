using Microsoft.AspNetCore.Components;
using shared.Models.ApiModels;

namespace ui.Components.Atoms;

public partial class RaceContent
{
    [Parameter]
    public RaceApiModel Race { get; set; }
} 