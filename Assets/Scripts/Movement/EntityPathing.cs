using br.com.Fonazo.Movement;
using UnityEngine;

namespace br.com.Fonazo.AI
{
    public class EntityPathing : CharacterMovement
    {
        [SerializeField] internal Checkpoint2D[] patrolPoints;
        internal AwaitableCompletionSource<bool> completionSource = new AwaitableCompletionSource<bool>();

        [SerializeField] private EntityData entityData;

        internal override async void Start()
        {
            if (entityData != null) 
                entityData.SetEntityMovementData(this);
            //await IsInterestInSight()
        }

        /*internal Awaitable<bool> IsInterestInSight()
        {
            return false;
        }*/

        #region Patroller

        internal virtual void StartPatrol()
        {
            transform.position = Vector3.Lerp(transform.position, patrolPoints[0].position, moveSpeed * Time.deltaTime);
        }

        #endregion
        
        internal virtual void ChangePathing()
        {

        }
        
        #region Seeker

        internal virtual void StartSeeker()
        {

        }

        #endregion
    }
}