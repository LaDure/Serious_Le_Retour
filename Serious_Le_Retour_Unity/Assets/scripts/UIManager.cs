using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public static UIManager Instance { get; private set; }

    public Text text;
    public GameObject PopUpReward;
    
    public GameObject Main;
    public GameObject Difficult;
    public GameObject Ecran1;
    public GameObject Ecran2;
    public GameObject Ecran3;
    public GameObject Ecran4;

    public bool InUi { get; private set; }


    private void Awake()
    {
        Instance = this;
        InUi = false;
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

    public void ChooseDifficult()
    {
        this.Main.SetActive(false);
        Difficult.SetActive(true);
    }

    public void Close()
    {
        this.Main.SetActive(true);
        Ecran1.SetActive(false);
        Ecran2.SetActive(false);
        Ecran3.SetActive(false);
        Ecran4.SetActive(false);
        Difficult.SetActive(false);

        InUi = false;
    }

    public void Active1()
    {
        this.Main.SetActive(false);
        Ecran1.SetActive(true);
        Ecran2.SetActive(false);
        Ecran3.SetActive(false);
        Ecran4.SetActive(false);

        InUi = true;
    }

    public void Active2()
    {
        this.Main.SetActive(false);
        Ecran1.SetActive(false);
        Ecran2.SetActive(true);
        Ecran3.SetActive(false);
        Ecran4.SetActive(false);

        InUi = true;
    }

    public void Active3()
    {
        this.Main.SetActive(false);
        Ecran1.SetActive(false);
        Ecran2.SetActive(false);
        Ecran3.SetActive(true);
        Ecran4.SetActive(false);

        InUi = true;
    }

    public void Active4()
    {
        this.Main.SetActive(false);
        Ecran1.SetActive(false);
        Ecran2.SetActive(false);
        Ecran3.SetActive(false);
        Ecran4.SetActive(true);

        InUi = true;
    }
}
