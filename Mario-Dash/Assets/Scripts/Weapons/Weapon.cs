using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
    /// <summary>
    /// Auteur: Alexis Harrington
    /// Description: Contient les attributs communs � toutes les armes.
    /// Date: 2021-03-20
    /// </summary>
    public class Weapon : MonoBehaviour
    {
        #region Propri�t�s
        public string WeaponName { get; set; }
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
        private void HurtEnemy()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
