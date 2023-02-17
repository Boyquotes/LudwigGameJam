using Godot;
using System;

public class creatureCardBase : MarginContainer
{
    // Declare member variables here
    // Default values for health, attack, and level
    private int health, attack, combatHealth, combatAttack, level;
    // Boolean value for if the card is Attacking or if the card is in combat phase
    private Boolean Attacker, inCombat;
    // Default strings for card name, passive, and active abilities
    private string creatureName, passiveAbility, activeAbility;

    // Default Constructor for base card
    public creatureCardBase() {
        creatureName = "Coots";
        passiveAbility = "~MEOW~";
        activeAbility = "Scratch";
        Attacker = false;
        inCombat = false;
        health = 0;
        attack = 0;
        combatHealth = 0;
        combatAttack = 0;
        level = 1;
    }

    // Virtual method for activating card passive
    public virtual void activatePassive() {}
    // Virtual method for activating card active
    public virtual void activateActive() {}

    // Set card to attacker
    public void setAttacker() {
        Attacker = true;
    }
    // Set card to supporter
    public void setSupporter() {
        Attacker = false;
    }
    // Is this card an attacker?
    public Boolean isAttacker() {
        return Attacker;
    }
    // Function to reduce health (take damage / debuff) returns new health value
    public int reduceHealth(int x) {
        if (inCombat) {
            combatHealth -= x;
            return combatHealth;
        } else {
            health -= x;
            return health;
        }
    }
    // Function to increase health (heal damage / buff) returns new health value
    public int increaseHealth(int x) {
        if (inCombat) {
            combatHealth += x;
            return combatHealth;
        } else {
            health += x;
            return health;
        }
    }
    // Function to reduce attack (debuff) returns new attack value
    public int reduceAttack(int x) {
        if (inCombat) {
            combatAttack -= x;
            return combatAttack;
        } else {
            attack -= x;
            return attack;
        }
    }
    // Function to increase health (buff) returns new attack value
    public int increaseAttack(int x) {
        if (inCombat) {
            combatAttack += x;
            return combatAttack;
        } else {
            attack += x;
            return attack;
        }
    }
    // Function to increase level (buff) returns new level
    public int increaseLevel() {
        return level++;
    }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
