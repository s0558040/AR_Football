using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IKeeper
{
    IKeeper GetNextState();
    IKeeper GetPreviousState();
    IKeeper GetAnyState();
    void PlayAnimation(float x, float y);
}
