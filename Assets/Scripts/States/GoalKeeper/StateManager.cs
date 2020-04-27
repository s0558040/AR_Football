using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    private IKeeper _state;
    private float _turn = 0.0F;
    private float _height = 0.0F;

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

    public void NextState()
    {
        _state = _state.GetNextState();
    }

    public void PreviousState()
    {
        _state = _state.GetPreviousState();
    }

    public void BackToStart()
    {
        _state = _state.GetAnyState();
    }

    public string ToString()
    {
        return _state.ToString();
    }

}
