using System.Collections;
using System.Collections.Generic;
using Assets.SuperGoalie.Scripts.Entities;
using UnityEngine;

/**
 * @author Stefan Manthey
 * Script to control the behavior of the goalkeeper
 */
public class GoalKeeperController : MonoBehaviour
{
    private StateManager _stateManager;     // animation state manager to control the animations (and translation)
    private Vector3 _origin;                // origin position of the goalkeeper
    private bool _isWalking = false;        // to check if the goalkeeper is already walking
    private float _turn;                    // direction (left and right) for the walking and jumping animation
    private float _height;                  // height (and intensity) for the jumping animation
    
    public BallController ball;
    public Transform keeperModel;

    private void Start()
    {
        _stateManager = gameObject.GetComponentInChildren<StateManager>();
        _origin = keeperModel.localPosition;
    }

    private void Update()
    {
        // only starts walking animation cicle if the ball is launched and the goalkeeper
        // isn't already beeing walking
        if (ball.IsLaunched() && !_isWalking)
        {
            StartWalking();
        }
    }

    /**
     * <summary>Starts animation (and translation) cicle of the goalkeeper
     * Direction and height to jump will be set randomly
     * Every animation state of the animation cicle will be invoked for a second</summary>
     */
    private void StartWalking()
    {
        _isWalking = true;
        _stateManager.Turn = Random.Range(-1.0F, 1.0F);
        _stateManager.Height = Random.Range(0.0F, 1.0F);
        InvokeRepeating("NextAnimationState", 0.0F, 1.0F);
    }

    /**
     * <summary>Activates the next animation state of the goalkeeper</summary>
     */
    private void NextAnimationState()
    {
        _stateManager.NextState();
    }

    /**
     * <summary>Resets the goalkeeper to his origin position and set the animation
     * of the goalkeeper back to idle</summary>
     */
    public void ResetGoalKeeper()
    {
        if (IsInvoking("NextAnimationState"))
        {
            CancelInvoke("NextAnimationState");
            _stateManager.BackToStart();
            _stateManager.NextState();
        }
        keeperModel.localPosition = _origin;
        _isWalking = false;
        _stateManager.Turn = 0.0F;
        _stateManager.Height = 0.0F;
    }
}
