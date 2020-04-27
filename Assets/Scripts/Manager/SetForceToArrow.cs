using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * @author Stefan Manthey
 * Script to stretch or upset the force arrow model
 */
public class SetForceToArrow : MonoBehaviour
{
    public int maxArrowLength = 10;     // maximum length factor for the arrow model
    public Transform arrow;             // arrow transform component of the arrow model
    public Slider slider;               // uGUI/GUI Slider to in-/decrease the arrow model z-scale

    private void Start()
    {
        StretchArrow();
    }

    public void StretchArrow()
    {
        Vector3 scale = arrow.localScale;
        scale.z = (slider.value / slider.maxValue) * maxArrowLength;    // uses the maximum length factor to keep the transform scale of the model independent from the actual slider value
        arrow.transform.localScale = scale;
    }
}
