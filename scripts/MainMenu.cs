using Godot;
using Godot.NativeInterop;
using System;

public partial class MainMenu : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var exit = GetNode<Button>("VBoxContainer/ButtonExit");
		var play = GetNode<Button>("VBoxContainer/ButtonPlay");
		exit.Pressed += onExitPressed;
		play.Pressed += onPlayPressed;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void onExitPressed()
	{
		GetTree().Quit();
	}
	public void onPlayPressed()
	{
		GetTree().ChangeSceneToFile("res://scenes/game.tscn");
	}
}
