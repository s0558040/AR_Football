using Assets.SuperGoalie.Scripts.Entities;
using Assets.SuperGoalie.Scripts.States.GoalKeeperStates.Idle.MainState;
using System;
using UnityEngine;

/**
 * Foreign code from SuperGoalie(Basic)
 * Source: https://assetstore.unity.com/packages/templates/packs/super-goalie-basic-144535
 * Script was now used in the AR_Football project
 */
namespace Assets.SuperGoalie.Scripts.Others.EntitiesAnimationEvents
{
    public class GoalKeeperAnimationEvents : MonoBehaviour
    {
        public GoalKeeper Owner;

        public void GoToIdleState()
        {
            Owner.FSM.ChangeState<IdleMainState>();
        }

        public void GoToSleepState()
        {
            throw new NotImplementedException();
        }

        public void OnAnimatorIK(int layerIndex)
        {
            Owner.FSM.OnAnimatorIK(layerIndex);
        }

        private void OnAnimatorMove()
        {
            Owner.FSM.OnAnimatorMove();
        }
    }
}
