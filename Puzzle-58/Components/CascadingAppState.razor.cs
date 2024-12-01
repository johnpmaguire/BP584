using Microsoft.AspNetCore.Components;

namespace Puzzle_58.Components;

public partial class CascadingAppState : ComponentBase
{
	[Parameter]
	public RenderFragment ChildContent { get; set; }

	public Client CurrentClient { get; set; }

	// Add properties here that you want to share across all clients
}