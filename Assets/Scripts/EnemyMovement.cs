using System;
using br.com.Fonazo.Movement;
using UnityEngine;

namespace br.com.Fonazo.Movement
{
    public class EnemyMovement : EntityPathing
    {
        internal override void Start()
        {
            base.Start();
            MoveToNextPoint();
        }
    }
}