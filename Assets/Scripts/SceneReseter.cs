using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Eigener Code
public class SceneReseter : MonoBehaviour
{
    public BallController ballController;
    public ArrowController arrowController;
    public GoalKeeperController goalKeeperController;

    public void ResetScene()
    {
        ballController.ResetBall();
        arrowController.ResetArrow();
        goalKeeperController.ResetGoalKeeper();
    }
}
