using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Player
{
    /// <summary>
    /// Auteur: Alexis Harrington
    /// Description: G�re la vie du joueur.
    /// Date: 2021-03-21
    /// </summary>
    public class HealthManager : MonoBehaviour
    {
        #region Propri�t�s
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        #endregion

        #region Main
        void Start()
        {

        }

        void Update()
        {

        }
        #endregion

        #region M�thodes
        public void HurtPlayer(int damage)
        {
            Health -= damage;

            // ...
        }
        #endregion
    }
}
