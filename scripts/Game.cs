using Godot;
using System;
using System.Runtime.CompilerServices;

public partial class Game : Godot.Node
{
	private PauseMenu _pauseMenu;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Viewport Size: ", GetViewport().GetVisibleRect().Size);
		_pauseMenu = GetNode<PauseMenu>("CanvasLayer/PauseMenu");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public override void _Input(InputEvent @event)
   {
		if (@event is InputEventKey key &&
			key.Keycode == Key.Escape &&
			key.Pressed	&&
			!key.Echo)
		{
				_pauseMenu.TogglePause();
		}
	}
}
