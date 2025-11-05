using br.com.Fonazo.Movement;
using UnityEngine;
using UnityEngine.Serialization;

namespace br.com.Fonazo.Movement
{
    public class EntityPathing : CharacterMovement
    {
        [SerializeField] private Checkpoint2D[] patrolPoints;

        private void OnEnable()
        {
            
        }

        private void OnDisable()
        {
            
        }

        internal virtual void MoveToNextPoint()
        {
            //if ()
        }
    }
}