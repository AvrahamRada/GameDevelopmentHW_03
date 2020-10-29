using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderBehaviour : MonoBehaviour
{
    public Text levelTxt;
    public static int speed_level = 5;

    public void sliderUpdate (float value)
    {
        levelTxt.text = "" + Mathf.RoundToInt(value);
        speed_level = Mathf.RoundToInt(value);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
