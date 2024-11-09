using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
     private Player player;
    private Enemy enemy;

    void Start()
    { 
        player = new Player("Hero", 100);
        enemy = new Enemy("Goblin", 50);

      
        Debug.Log($"Player: {player.Name}, Health: {player.Health}");
        Debug.Log($"Enemy: {enemy.Name}, Health: {enemy.Health}");

      
        player.Heal(20);

       
        enemy.Attack(player, 15);
    }
}
