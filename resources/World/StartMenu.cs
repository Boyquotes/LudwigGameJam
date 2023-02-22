using Godot;
using System;

public class StartMenu : Control
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        VisualServer.SetDefaultClearColor(Colors.DimGray);
    }

    public void _on_Quit_pressed() {
        GetTree().Quit();
    }
    public void _on_Start_Game_pressed() {
        GetTree().ChangeScene("res://resources/World/teamBuilder.tscn");
    }
}
