using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnyState : MonoBehaviour, IKeeper
{
    private Animator _anim;
    private Idle _nextState;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _nextState = GetComponent<Idle>();
    }

    public IKeeper GetNextState()
    {
        _anim.SetTrigger("Idle");
        return _nextState;
    }

    public IKeeper GetPreviousState()
    {
        return this;
    }

    public IKeeper GetAnyState()
    {
        return this;
    }

    public void PlayAnimation(float x, float y) { }
}
