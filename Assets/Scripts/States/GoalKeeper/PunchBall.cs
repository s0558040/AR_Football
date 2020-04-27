using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchBall : MonoBehaviour, IKeeper
{
    private Animator _anim;
    private WakeupNoBall _nextState;
    private AnyState _anyState;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _nextState = GetComponent<WakeupNoBall>();
        _anyState = GetComponent<AnyState>();
    }
    public IKeeper GetNextState()
    {
        _anim.SetTrigger("Exit");
        return _nextState;
    }

    public IKeeper GetPreviousState()
    {
        return this;
    }

    public IKeeper GetAnyState()
    {
        return _anyState;
    }

    public void PlayAnimation(float x, float y)
    {
        _anim.SetFloat("Turn", x);
        _anim.SetFloat("Hight", y);
    }
}
