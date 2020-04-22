using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetForceToArrow : MonoBehaviour
{
    public int maxArrowLength = 10;
    public Transform arrow;
    public Slider slider;

    private void Start()
    {
        StretchArrow();
    }

    public void StretchArrow()
    {
        Vector3 scale = arrow.localScale;
        scale.z = (slider.value / slider.maxValue) * maxArrowLength;
        arrow.transform.localScale = scale;
    }
}
