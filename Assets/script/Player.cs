using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public class Player : Character
    {
        public Player(string name, int health)  { }

        public void Heal(int amount)
        {
            Health += amount;
          Debug.Log($"{Name} healed by {amount}. Health is now {Health}.");
        }
        
    }