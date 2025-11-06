using System;
using br.com.Fonazo.Movement;
using UnityEngine;

namespace br.com.Fonazo.Movement.AI
{
    public class EnemyMovement : EntityPathing
    {
        internal override void Start()
        {
            base.Start();
            StartPatrolPath();
        }
    }
}