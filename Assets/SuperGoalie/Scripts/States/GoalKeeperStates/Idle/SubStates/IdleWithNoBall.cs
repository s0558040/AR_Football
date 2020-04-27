using System;
using Assets.SuperGoalie.Scripts.Entities;
using Assets.SuperGoalie.Scripts.FSMs;
using RobustFSM.Base;

/**
 * Foreign code from SuperGoalie(Basic)
 * Source: https://assetstore.unity.com/packages/templates/packs/super-goalie-basic-144535
 * Script was now used in the AR_Football project
 */
namespace Assets.SuperGoalie.Scripts.States.GoalKeeperStates.Idle.SubStates
{
    public class IdleWithNoBall : BState
    {
        public override void Enter()
        {
            base.Enter();

            //register to goalkeeper events
            Owner.OnHasBall += Instance_OnHasBall;

            //set the animator
            Owner.Animator.SetBool("HasBall", false);
        }

        public override void Exit()
        {
            base.Exit();

            //deregister to goalkeeper events
            Owner.OnHasBall -= Instance_OnHasBall;
        }

        private void Instance_OnHasBall()
        {
            Machine.ChangeState<IdleWithBall>();
        }

        GoalKeeper Owner
        {
            get
            {
                return ((GoalKeeperFSM)SuperMachine).Owner;
            }
        }
    }
}
