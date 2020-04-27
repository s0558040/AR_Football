using Assets.SuperGoalie.Scripts.States.GoalKeeperStates.InteractWithBall.SubStates;
using RobustFSM.Base;

/**
 * Foreign code from SuperGoalie(Basic)
 * Source: https://assetstore.unity.com/packages/templates/packs/super-goalie-basic-144535
 * Script was now used in the AR_Football project
 */
namespace Assets.SuperGoalie.Scripts.States.GoalKeeperStates.InteractWithBall.MainState
{
    public class InteractWithBallMainState : BHState
    {
        public override void AddStates()
        {
            AddState<CatchBall>();
            AddState<CheckIfBallIsCatchableOrPunchable>();
            AddState<ClearBall>();

            SetInitialState<CheckIfBallIsCatchableOrPunchable>();
        }
    }
}
