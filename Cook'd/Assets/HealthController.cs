using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DebugPlayer
{
    public class HealthController : MonoBehaviour
    {
        public GameObject Gameover;

        [Header("Health Properties")]
        public int currentHealth;
        private int maxHealth = 0;

        void Start()
        {
            currentHealth = maxHealth;

            GameEvents.current.onDamageEntity += DamageEntity;
            GameEvents.current.onHealEntity += HealEntity;


         
        }

        public void DamageEntity(int _amount)
        {
            currentHealth -= _amount;

            UIEvents.current.HealthUpdate(currentHealth);

            if (currentHealth >= 50)
            {
                Gameover.SetActive(true);


                Debug.Log("YOUR MOMMA");

            }
            else
            {
                Gameover.SetActive(false);


            }
        }

        public void HealEntity(int _amount)
        {
            currentHealth += _amount;

            UIEvents.current.HealthUpdate(currentHealth);

            if (currentHealth >= 50)
            {
                Gameover.SetActive(true);


                Debug.Log("YOUR MOMMA");

            }
            else
            {
                Gameover.SetActive(false);


            }
        }
    }
}