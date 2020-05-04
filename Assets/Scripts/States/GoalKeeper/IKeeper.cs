using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @author Stefan Manthey
 * Interface to koordinate the animation behaviour of the goalkeeper
 * Heavily inspired from the state pattern
 */
public interface IKeeper
{
    /**
     * <summary>Triggers the next animation phase and returns the new state</summary>
     * <returns>Next animation state</returns>
     */
    IKeeper GetNextState();
    /**
     * <summary>Triggers the previous animation phase (if connection is available) and retunrs the new state</summary>
     * <returns>Previous animation state if connection available, else returns current state</returns>
     */
    IKeeper GetPreviousState();
    /**
     * <summary>Triggers the AnyState animation phase and return the new state</summary>
     * <returns>The AnyState animation state</returns>
     */
    IKeeper GetAnyState();
    /**
     * <summary>Starts animation of current animation phase</summary>
     * <param name="x">Turn value, direction to move. Value between -1 an 1</param>
     * <param name="y">Height value, jump height. Value between 0 and 1</param>
     */
    void PlayAnimation(float x, float y);
}
