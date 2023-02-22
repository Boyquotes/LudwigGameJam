using Godot;
using System;

public class GameState : Node2D
{
    const int STATE1 = 0;
    const int STATE2 = 1;
    const int STATE3 = 3;

    public int state;
    
    public override void _Ready()
    {
        
    }

 // Called every frame. 'delta' is the elapsed time since the previous frame.
 public override void _Process(float delta)
 {
  switch (state){
    case STATE1:

        //Do some stuff
        //if condition to go to next state
            //state = one of the other states
        break;
    case STATE2:
        break;
    case STATE3:
        break;
    default:
        break;

        
  }   
 }
}
