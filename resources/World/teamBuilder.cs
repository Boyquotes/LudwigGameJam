using Godot;
using System;

public class teamBuilder : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    bool suppL = false;
    bool suppR = false;
    bool attack = false;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public void _on_mouseClickDetector_input_event(Viewport view, InputEvent @event, int shape_idx) {
        if (@event is InputEventMouseButton && @event.IsPressed()) {
            GD.Print("Mouse Click Detected!!!!! Event Type: ", @event);
        }
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//     public override void _Process(float delta)
//     {
            
//     }
}
