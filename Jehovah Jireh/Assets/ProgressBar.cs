using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour {

    public Slider slider;
    
    // 0 - 100 %
    public void ChangeProgress(int originPercent, int toPercent)
    {
        slider.value = (float)toPercent / 100.0f;
    }

}
