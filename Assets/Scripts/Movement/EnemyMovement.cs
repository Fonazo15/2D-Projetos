using br.com.Fonazo.Movement;
using UnityEngine;

namespace br.com.Fonazo.AI
{
    public class EnemyMovement : EntityPathing
    {
        internal override void Start()
        {
            base.Start();
            StartPatrol();
        }
    }
}