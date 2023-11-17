using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA
{
    public class DamageTrigger : MonoBehaviour
    {
        public float damage = 2f;


        //OnTriggerEnter2D
        private void OnTriggerEnter2D(Collider2D other) 
        {
            if(other.gameObject.CompareTag("Enemy"))
            {
                other.GetComponent<EnemyHealth>().TakeDamage(damage);
            }
        }
    }
}
