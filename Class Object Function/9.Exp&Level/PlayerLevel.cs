using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA
{
    public class PlayerLevel : MonoBehaviour
    {   
        public int maxExp;
        public int currentExp;
        public int currentLevel = 1;
        // [Header("Upgrade Panel")]
        // public UpgradePanel upgradePanel; //เพิ่มเข้าไปทีหลังตอน Upgrade
        public float maxHealth;
        public GameObject sword1;
         public GameObject sword2;
          public GameObject sword3;
        public void LevelUp()
        {
            currentExp = 0;
            currentLevel = currentLevel + 1;

            maxExp = Mathf.RoundToInt(maxExp * 1.25f);
            GetComponent<PlayerHealth>().maxHealth = Mathf.RoundToInt(GetComponent<PlayerHealth>().maxHealth * 1.10f);
            GetComponent<PlayerHealth>().currentHealth += maxHealth;
            if(currentLevel == 2)
            {
                sword1.SetActive(true);
            }
            if(currentLevel == 3)
            {
                sword2.SetActive(true);
            }
            if(currentLevel == 4)
            {
                sword3.SetActive(true);
            }
            //เพิ่มเข้าไปทีหลังตอน Upgrade
            // SetCard();
            
        }

        public void GetExp(int amount)
        {
            currentExp = currentExp + amount;
            if(currentExp >= maxExp)
            {
                LevelUp();
            }
        }

        // void SetCard()
        // {
        //     if(upgradePanel != null)
        //     {
        //         upgradePanel.SetCard();
        //     }
        // }
    }
}
