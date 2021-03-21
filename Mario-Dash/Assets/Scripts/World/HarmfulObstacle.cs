using Assets.Scripts.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.World
{
    /// <summary>
    /// Auteur: Alexis Harrington
    /// Description: D�finit un obstacle pr�sent dans le monde.
    ///              Est un obstacle qui fait perdre de la vie au joueur (IHarmfulObstacle).
    /// Date: 2021-03-20
    /// </summary>
    public class HarmfulObstacle : Obstacle, IHarmfulObstacle
    {
        #region Propri�t�s
        public HealthManager HealthManager { get; set; }
        public int Damage { get; set; }
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
        public void HurtPlayerOnContact()
        {
            HealthManager.HurtPlayer(Damage);

            // ...
        }
        #endregion
    }
}
