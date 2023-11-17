using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA
{
    public class EXPItemScript : MonoBehaviour
    {
        [Header("Lerp To Player")]
        PlayerLevel playerLevel;
        public float lerpSpeed = 1f;
        public bool isMoveToPlayer = false; 
        float time = 0f;

        void Start() 
        {
            playerLevel = FindObjectOfType<PlayerLevel>().GetComponent<PlayerLevel>();    
        }

        private void OnTriggerEnter2D(Collider2D other) 
        {
            if(other.CompareTag("Player"))
            {
                playerLevel.GetExp(10);
                Destroy(this.gameObject);
            }
        }

        private void FixedUpdate() 
        {
            MoveToPlayer();
            LeapToPlayer();
        }

        void MoveToPlayer()
        {
            if(isMoveToPlayer)
                time = Time.deltaTime * lerpSpeed;
        }

        public void LeapToPlayer()
        {
            transform.position = Vector3.Lerp(transform.position, playerLevel.transform.position,time);
        }
    }
}
