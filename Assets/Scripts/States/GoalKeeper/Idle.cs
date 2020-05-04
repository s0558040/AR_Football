using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @author Stefan Manthey
 * Script for the Idle animation behaviour
 */
public class Idle : MonoBehaviour, IKeeper
{
    private Animator _anim;
    private TendGoal _nextState;
    private AnyState _anyState;

    void Start()
    {
        _anim = GetComponent<Animator>();
        _nextState = GetComponent<TendGoal>();
        _anyState = GetComponent<AnyState>();
    }
    public IKeeper GetNextState()
    {
        _anim.SetTrigger("TendGoal");
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

    public void PlayAnimation(float x, float y) { }
}
