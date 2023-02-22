using Godot;
using System;

public class Player : Node2D
{
    // Declare member variables here. Examples:
    private int health, money;

    private creatureCardBase attacker, supportL, supportR;

    //private itemCardBase shopCard;

    // Called when the node enters the scene tree for the first time.

    public Player(creatureCardBase att, creatureCardBase suppL, creatureCardBase suppR) {
        health = 3;
        money = 10;

        attacker = att;
        supportL = suppL;
        supportR = suppR;

        //shopCard = null;
    }

    public void buyCard(){
        if (money >= 1){
            money-=1;
            //shopcard = (get a random card)
        }
    }

    public void rotate(Boolean direction){
        //0 = clockwise, 1 = counterclk
        creatureCardBase curAtt = attacker;
        creatureCardBase curSuppL = supportL;
        creatureCardBase curSuppR = supportR;

        if (direction){
            attacker = curSuppR;
            supportL = curAtt;
            supportR = curSuppL;
        }
        else{
            attacker = curSuppL;
            supportL = curSuppR;
            supportR = curAtt;
        }
    }

    

    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
