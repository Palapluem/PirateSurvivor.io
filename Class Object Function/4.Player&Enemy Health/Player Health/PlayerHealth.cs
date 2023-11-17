using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TA
{
    public class PlayerHealth : MonoBehaviour
    {
        public float maxHealth = 1000f;
        public float currentHealth = 0f;

        void Start()
        {
            currentHealth = maxHealth;
            Time.timeScale = 1;
        }

        public void TakeDamage(float damage)
        {
            // เพิ่มการคำนวณความเสียหาย: HP ของผู้เล่นถูกลดด้วยพลังโจมตีศัตรู
            currentHealth = currentHealth - damage;
            if(currentHealth <= 0)
            {
                this.gameObject.SetActive(false);
            }
        }

        public void Heal(float amount)
        {
            currentHealth += amount;

            if(currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
             
        }
    }
}