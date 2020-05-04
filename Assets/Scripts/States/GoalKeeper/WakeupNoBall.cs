using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @author Stefan Manthey
 * Script for WakeupNoBall animation behaviour
 */
public class WakeupNoBall : MonoBehaviour, IKeeper
{
    private Animator _anim;
    private Idle _nextState;
    private AnyState _anyState;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _nextState = GetComponent<Idle>();
        _anyState = GetComponent<AnyState>();
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
        return _anyState;
    }

    public void PlayAnimation(float x, float y)
    {
        _anim.SetFloat("Turn", x);
        _anim.SetFloat("Height", y);
    }
}
