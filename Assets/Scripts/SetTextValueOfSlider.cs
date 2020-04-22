using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTextValueOfSlider : MonoBehaviour
{
    public Slider slider;
    public Text text;

    private void Start()
    {
        text.text = string.Format("{0}: {1}", "Force:", slider.value);
    }
    public void SetText(string kind)
    {
        text.text = string.Format("{0}: {1}", kind, slider.value);
    }
}
