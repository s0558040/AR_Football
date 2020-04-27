using Assets.SuperGoalie.Scripts.Entities;
using Assets.SuperGoalie.Scripts.States.GoalKeeperStates.Dive.MainState;
using Assets.SuperGoalie.Scripts.States.GoalKeeperStates.Idle.MainState;
using Assets.SuperGoalie.Scripts.States.GoalKeeperStates.IgnoreShot.MainState;
using Assets.SuperGoalie.Scripts.States.GoalKeeperStates.InteractWithBall.MainState;
using Assets.SuperGoalie.Scripts.States.GoalKeeperStates.InterceptShot.MainState;
using Assets.SuperGoalie.Scripts.States.GoalKeeperStates.TendGoal.MainState;
using RobustFSM.Base;

/**
 * Foreign code from SuperGoalie(Basic)
 * Source: https://assetstore.unity.com/packages/templates/packs/super-goalie-basic-144535
 * Script was now used in the AR_Football project
 */
namespace Assets.SuperGoalie.Scripts.FSMs
{
    public class GoalKeeperFSM : BFSM
    {
        public GoalKeeper Owner { get; set; }

        public override void AddStates()
        {
            AddState<PunchBallMainState>();
            AddState<IdleMainState>();
            AddState<IgnoreShotMainState>();
            AddState<InterceptShotMainState>();
            AddState<TendGoalMainState>();

            SetInitialState<IdleMainState>();
        }

        private void Awake()
        {
            Owner = GetComponent<GoalKeeper>();
        }
    }
}
