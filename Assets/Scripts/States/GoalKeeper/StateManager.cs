using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @author Stefan Manthey
 * Script to manage animation states of the goalkeeper
 */
public class StateManager : MonoBehaviour
{
    private IKeeper _state;         // current animation state
    private float _turn = 0.0F;     // direction to move
    private float _height = 0.0F;   // height to jump

    public float Turn
    {
        get
        {
            return _turn;
        }
        set
        {
            _turn = value;
        }
    }

    public float Height
    {
        get
        {
            return _height;
        }
        set
        {
            _height = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        _state = GetComponent<Idle>();
    }

    // Update is called once per frame
    void Update()
    {
        _state.PlayAnimation(_turn, _height);
    }

    /**
     * <summary>Sets the next animation state active</summary>
     */
    public void NextState()
    {
        _state = _state.GetNextState();
    }

    /**
     * <summary>Sets the previous animation state active, if available</summary>
     */
    public void PreviousState()
    {
        _state = _state.GetPreviousState();
    }

    /**
     * <summary>Sets current animation state to AnyState</summary>
     */
    public void BackToStart()
    {
        _state = _state.GetAnyState();
    }

}
