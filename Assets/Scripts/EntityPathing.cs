using br.com.Fonazo.Movement;
using UnityEngine;
using UnityEngine.Serialization;

namespace br.com.Fonazo.Movement.AI
{
    public class EntityPathing : CharacterMovement
    {
        [SerializeField] internal Checkpoint2D[] patrolPoints;

        private void OnEnable()
        {
            
        }

        private void OnDisable()
        {
            
        }

        #region Patroller

        internal virtual void StartPatrolPath()
        {
            transform.position = Vector3.Lerp(transform.position, patrolPoints[0].position, moveSpeed * Time.deltaTime);
        }

        #endregion
        
        
        #region Seeker

        internal virtual void StartSeekerPath()
        {

        }

        #endregion
    }
}