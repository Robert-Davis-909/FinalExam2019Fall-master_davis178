using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KeepData : MonoBehaviour
{
    public static float slider;
    public static string speed;
    public static int time;
    public static string PlayerName;
    public static int PlayerScore;
    public static string PlayerSize;

    public Dropdown PlayerTime;
    public Slider PlayerSlider;
    public Dropdown PlayerSpeed;
    public InputField PlayerNameInput;
  

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void sliderValue()
    {
        slider = PlayerSlider.value;
    }

    public void speedValue()
    {
        switch (PlayerSpeed.value)
        {
            case 1:
                speed = "slow";
                break;

            case 2:
                speed = "fast";
                break;

            default:
                speed = "Normal";
                break;
        }
    }

    public void timeValue()
    {
        switch (PlayerTime.value)
        {
            case 1:
                time = 15;
                break;

            case 2:
                time = 30;
                break;

            default:
                time = 00;
                break;
        }
        ;
    }

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
    }

}
