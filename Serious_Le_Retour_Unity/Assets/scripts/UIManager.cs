using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public static UIManager Instance { get; private set; }

    public Text text;
    public GameObject PopUpReward;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateText(int day)
    {
        text.text = "Jour " + day.ToString();
    }

    public void PopUp()
    {
        this.PopUpReward.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void ClosePopUp()
    {
        this.PopUpReward.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
