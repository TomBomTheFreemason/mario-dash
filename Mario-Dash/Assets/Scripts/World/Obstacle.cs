using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.World
{
    /// <summary>
    /// Auteur: Alexis Harrington
    /// Description: D�finit un obstacle pr�sent dans le monde.
    ///              D�finit les attributs communs � tous les obstacles.
    /// Date: 2021-03-20
    /// </summary>
    public class Obstacle : MonoBehaviour
    {
        #region Propri�t�s
        public string ObstacleName { get; set; }
        public GameObject ObstacleGameObject { get; set; }
        #endregion

        #region Main
        void Start()
        {

        }

        void Update()
        {

        }
        #endregion
    }
}
