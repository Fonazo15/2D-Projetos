using br.com.Fonazo.Movement;
using UnityEngine;

namespace br.com.Fonazo.AI
{
    public class EntityPathing : CharacterMovement
    {
        [SerializeField] internal Checkpoint2D[] patrolPoints;

        [SerializeField] private EntityData _entityData;
        private Transform Target
        {
            get
            {
                return GameObject.FindGameObjectWithTag(targetTag).GetComponent<Transform>();
            }
        }
        
        [SerializeField] internal float sightDistance;
        [SerializeField] internal string targetTag;
        [SerializeField] internal EntityPathingState pathingState = EntityPathingState.None;

        internal override void Awake()
        {
            base.Awake();
            //if (_entityData == null) _entityData = ScriptableObject.CreateInstance<EntityData>();
        }
        private async void Start()
        {
            while (pathingState == EntityPathingState.Patrol)
            {
                Debug.Log(await StartPatrol());
            }
            while (pathingState == EntityPathingState.Seek)
            {
                await StartSeeker();
            }
            await Awaitable.NextFrameAsync();
        }

        #region Patroller
        public async Awaitable<bool> StartPatrol()
        {
            bool hasStarted = Vector2.Distance(transform.position, Checkpoint2D.GetStartPoint(patrolPoints).position) <= 0.1f;
            while (!hasStarted)
            {
                transform.position = Vector2.MoveTowards(transform.position, Checkpoint2D.GetStartPoint(patrolPoints).position, moveSpeed * Time.deltaTime);
                await Awaitable.NextFrameAsync();
            }
            if (hasStarted)
            {
                transform.position = new Vector2(100, 100);
            }
            return hasStarted;
        }

        #endregion

        #region Seeker

        public async Awaitable StartSeeker()
        {
            bool hasStarted = Vector2.Distance(transform.position, Target.position) <= 0.1f;
            while (!hasStarted)
            {
                transform.position = Vector2.MoveTowards(transform.position, Target.position, moveSpeed * Time.deltaTime);
                await Awaitable.NextFrameAsync();
            }
        }

        #endregion
    }
    public enum EntityPathingState
    {
        None,
        Seek,
        Patrol
    }
}