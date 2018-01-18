using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public static UIManager Instance { get; private set; }

    public Text text;
    public GameObject PopUpReward;
    
    public GameObject Main;
    public GameObject Daily;
    public GameObject Question;


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

    public void ActiveMain()
    {
        this.Main.SetActive(true);
        this.Daily.SetActive(false);
        this.Question.SetActive(false);
    }

    public void ActiveDaily()
    {
        this.Main.SetActive(false);
        this.Daily.SetActive(true);
        this.Question.SetActive(false);
    }

    public void ActiveQuestion()
    {
        this.Main.SetActive(false);
        this.Daily.SetActive(false);
        this.Question.SetActive(true);
    }
}
