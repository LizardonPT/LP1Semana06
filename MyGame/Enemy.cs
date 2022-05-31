using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        //Constructor
        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield <= 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health <= 0) health = 0;
            }
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        } 

        public void SetName(string name)
        {
            this.name = name.Trim();
        }

        public void PickupPowerUp(PowerUp type, float value)
        {
            if (type == PowerUp.Health)
            {
                health += value;
                if (health > 100)
                {
                    health = 100;
                }
            }

            if (type == PowerUp.Shield)
            {
                shield += value;
                if (shield > 100)
                {
                    shield = 100;
                }
            }
        }
    }
}