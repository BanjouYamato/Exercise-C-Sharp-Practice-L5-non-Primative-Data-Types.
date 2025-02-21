﻿//---------------------------------------------------------------------
// Question 1: Player Class
// Create a class named "Player" to represent a character in a role-playing game.
// Include attributes for the player's name, level, health points (HP), and experience points (XP).
// Implement methods to level up the player, heal the player, and gain experience points.
// Hint: Declare a class with properties for name, level, HP, and XP. Implement methods to increase level, heal HP, and gain XP.
/* Think about how players progress in a typical RPG game. Consider what actions a player can take and how they affect the player's attributes. */
using System.Diagnostics;

public class Player
{
    string name;
    int playerExperience = 0;
    int level = 1;
    public int HP;
    int ExpLevel = 10;
    int maxHp = 20;
    public int mana = 30;
    void Start()
    {
        HP = maxHp;
    }

    void GainExp()
    {
        playerExperience++;
    }
    void LevelUp()
    {
        if(playerExperience >= ExpLevel)
        {
            level++;
            maxHp += 20;
            ExpLevel *= 2;
            HP = maxHp;
        }
    }
    void TakeDamamge()
    {
        HP -= 2;
    }
    bool CheckDie()
    {
        return HP <= 0;
    }
    void RecoveryHp()
    {
        HP += 2;
    }
}

//---------------------------------------------------------------------
// Question 2: Enemy Class
// Develop a class called "Enemy" to represent adversaries in a video game.
// Include properties for the enemy's name, health points (HP), attack power, and defense.
// Implement methods to calculate damage inflicted by the enemy and to update their HP.
// Hint: Define a class with attributes for name, HP, attack power, and defense. Create methods to calculate damage and update HP.
/* Consider the role enemies play in games. They typically attack players and can be defeated by reducing their HP to zero. */
public class Enemy
{
    string name;
    public int HP;
    int maxHp = 20;
    void Start()
    {
        HP = maxHp;
    }

    void TakeDamamge()
    {
        HP -= 2;
    }
    bool CheckDie()
    {
        return HP <= 0;
    }
}

//---------------------------------------------------------------------
// Question 3: Potion Class
// Design a class named "Potion" to model health-restoring items in an adventure game.
// Include properties for the potion's name, healing power, and quantity in inventory.
// Implement a method to apply the potion to a player character and restore their health.
// Hint: Define a class with attributes for name, healing power, and quantity. Create a method to apply the potion and heal the player.
/* Think about how healing items function in games. They typically restore a portion of a player's health when consumed. */
public class Potion
{
    string name;
    int HPEffect = 2;
    int Quantity = 10;
    Player player;
    void Effect()
    {
        player.HP += HPEffect;
        Quantity -= 1;
    }
}
//---------------------------------------------------------------------
// Question 4: Quest Class
// Create a class called "Quest" to represent tasks or missions in a quest-based game.
// Include properties for the quest's name, description, reward, and completion status.
// Implement methods to start the quest, complete the quest, and claim the reward.
// Hint: Define a class with attributes for name, description, reward, and completion status. Implement methods to manage quest progress.
/* Consider the structure of quests in games. They often involve objectives, rewards, and tracking completion status. */
public class Quest
{
    string name;
    string description;
    string reward;
    bool status;
    
    void CompleteQuest()
    {
        status = true;
    }
}
//---------------------------------------------------------------------
// Question 5: Inventory Class
// Develop a class named "Inventory" to manage a player's items in a role-playing game.
// Include properties for the inventory's capacity, list of items, and methods to add/remove items.
// Implement functionality to check if an item exists in the inventory and display its details.
// Hint: Define a class with attributes for capacity and a list of items. Create methods to add, remove, and search for items.
/* Think about how inventories work in games. Players can store and manage various items they collect during their adventures. */
public class Inventory
{
    List<string> items = new List<string>();
    void AddtoInventory(string item)
    {
        items.Add(item);
    }
    void RemoveFromInventory(int index)
    {
        items.RemoveAt(index);
    }
    void CheckItem(string item)
    {
        if (items.Contains(item))
        {
            Console.WriteLine("Iventory have this item");
        }
        else
        {
            Console.WriteLine("Not exist this item in inventory");
        }
    }
}
//---------------------------------------------------------------------
// Question 6: Spell Class
// Design a class called "Spell" to represent magical abilities or spells in a fantasy game.
// Include properties for the spell's name, damage, mana cost, and description.
// Implement methods to cast the spell, consume mana, and display spell details.
// Hint: Define a class with attributes for name, damage, mana cost, and description. Implement methods to cast and describe the spell.
/* Consider the mechanics of spellcasting in fantasy games. Spells often have different effects, costs, and descriptions. */
public class Spell
{
    string name;
    string description;
    int damage;
    int manaCost = 5;
    Player player;
    Enemy enemy;

    void CastSpell()
    {
        enemy.HP -= damage;
        player.mana -= manaCost;
    }
    void DetailSpell()
    {
        Console.WriteLine(description);
    }
}