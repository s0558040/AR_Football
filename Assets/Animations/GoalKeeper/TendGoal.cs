using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TendGoal : MonoBehaviour, IKeeper
{
    private Animator _anim;
    private PunchBall _nextState;
    private Idle _previousState;
    private AnyState _anyState;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _nextState = GetComponent<PunchBall>();
        _previousState = GetComponent<Idle>();
        _anyState = GetComponent<AnyState>();
    }
    public IKeeper GetNextState()
    {
        _anim.SetTrigger("Dive");
        return _nextState;
    }

    public IKeeper GetPreviousState()
    {
        _anim.SetTrigger("Idle");
        return _previousState;
    }

    public IKeeper GetAnyState()
    {
        return _anyState;
    }

    public void PlayAnimation(float x, float y)
    {
        _anim.SetFloat("Turn", x);
    }
}
