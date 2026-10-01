using Godot;
using System;

public partial class PauseMenu : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Hide();

		var Resume = GetNode<Button>("VBoxContainer/ButtonResume");
		var MainMenu = GetNode<Button>("VBoxContainer/ButtonMainMenu");
		Resume.Pressed += onResumePressed;
		MainMenu.Pressed += onExitToMainMenuPressed;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void TogglePause()
	{
		bool isPaused = !GetTree().Paused;
		GetTree().Paused = isPaused;
		Visible = isPaused;
	}

	public void onResumePressed()
	{
		TogglePause();
	}

	public void onExitToMainMenuPressed()
	{
		GetTree().Paused = false;
		GetTree().ChangeSceneToFile("res://scenes/Main_Menu.tscn");
	}
}
