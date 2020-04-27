using Assets.SuperGoalie.Scripts.Entities;
using Assets.SuperGoalie.Scripts.FSMs;
using Assets.SuperGoalie.Scripts.States.GoalKeeperStates.Idle.SubStates;
using Assets.SuperGoalie.Scripts.States.GoalKeeperStates.TendGoal.MainState;
using RobustFSM.Base;

/**
 * Foreign code from SuperGoalie(Basic)
 * Source: https://assetstore.unity.com/packages/templates/packs/super-goalie-basic-144535
 * Script was now used in the AR_Football project
 */
namespace Assets.SuperGoalie.Scripts.States.GoalKeeperStates.Idle.MainState
{
    public class IdleMainState : BState
    {
        //public override void AddStates()
        //{
        //    AddState<CheckIfHasBall>();
        //    AddState<IdleWithBall>();
        //    AddState<IdleWithNoBall>();

        //    SetInitialState<CheckIfHasBall>();
        //}

        public override void Enter()
        {
            base.Enter();

            //set the components
            Owner.Animator.SetTrigger("Idle");
            Owner.RPGMovement.SetSteeringOff();
        }

        public override void Execute()
        {
            base.Execute();

            //if the ball is within threatening distance then tend goal
            if (Owner.IsBallWithThreateningDistance())
                Machine.ChangeState<TendGoalMainState>();
        }

        public override void Exit()
        {
            base.Exit();
            
            //reset the animator
            Owner.Animator.ResetTrigger("Idle");
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
