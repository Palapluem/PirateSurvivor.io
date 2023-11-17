using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA
{
    public class EnemyAttack : MonoBehaviour
    {
        public float enemyDamage = 10f;

        void OnTriggerEnter2D(Collider2D Player)
        {
            // ใช้ tag ในการตรวจสอบว่าเป็น Player ที่เข้ามาใน Trigger
            // เรียกใช้ Function รับความเสียหายใน PlayerHealth
            if(Player.tag == "Player")
            {
                Player.GetComponent<PlayerHealth>().TakeDamage(enemyDamage);
            }
        }
    }
}