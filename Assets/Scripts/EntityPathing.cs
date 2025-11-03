using br.com.Fonazo.Movement;
using UnityEngine;

namespace br.com.Fonazo.Movement
{
    public class EntityPathing : CharacterMovement
    {
        [SerializeField] private Checkpoint2D[] pathPoints;
    }
}