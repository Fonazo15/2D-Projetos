using br.com.Fonazo.Movement;
using UnityEngine;

namespace br.com.Fonazo
{
    namespace Movement
    {
        public class EntityPathing : CharacterMovement
        {
            [SerializeField] private Checkpoint[] pathPoints;
        }
    }
}