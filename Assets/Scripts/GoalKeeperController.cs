using System.Collections;
using System.Collections.Generic;
using Assets.SuperGoalie.Scripts.Entities;
using UnityEngine;

public class GoalKeeperController : MonoBehaviour
{
    private StateManager _stateManager;
    private Vector3 _origin;
    private bool _isWalking = false;
    private float _turn;
    private float _height;
    
    public BallController ball;
    public Transform keeperModel;

    private void Start()
    {
        _stateManager = gameObject.GetComponentInChildren<StateManager>();
        _origin = keeperModel.localPosition;
    }

    private void Update()
    {
        if (ball.IsLaunched() && !_isWalking)
        {
            StartWalking();
        }
    }

    private void StartWalking()
    {
        _isWalking = true;
        _stateManager.Turn = Random.Range(-1.0F, 1.0F);
        _stateManager.Height = Random.Range(0.0F, 1.0F);
        InvokeRepeating("NextAnimationState", 0.0F, 1.0F);
    }

    private void NextAnimationState()
    {
        _stateManager.NextState();
    }

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
