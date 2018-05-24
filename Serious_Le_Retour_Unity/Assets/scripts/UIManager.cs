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
    public GameObject Ecran1b;
    public GameObject Ecran2;
    public GameObject Ecran3;
    public GameObject Ecran4;
    public GameObject Ecran4b;
    public GameObject Chrono;
    public GameObject Run;
    public GameObject Stop;

    public GameObject StartPushUp;
    public GameObject StopPushUp;
    public GameObject Verif;

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
        this.PopUpReward.GetComponent<PopUpBehaviour>().Init();
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
        Ecran1b.SetActive(false);
        Ecran2.SetActive(false);
        Ecran3.SetActive(false);
        Ecran4.SetActive(false);
        Ecran4b.SetActive(false);
        Difficult.SetActive(false);
        Run.SetActive(true);
        Stop.SetActive(false);
        StartPushUp.SetActive(true);
        StopPushUp.SetActive(false);

        InUi = false;
    }

    public void Active1()
    {
        this.Main.SetActive(false);
        if(GameManager.Instance.day == 1)
            Ecran1.SetActive(true);
        else
            Ecran1b.SetActive(true);

        Ecran2.SetActive(false);
        Ecran3.SetActive(false);
        Ecran4.SetActive(false);
        Ecran4b.SetActive(false);

        InUi = true;
    }

    public void Active2()
    {
        this.Main.SetActive(false);
        Ecran1.SetActive(false);
        Ecran1b.SetActive(false);
        Ecran2.SetActive(true);
        Ecran3.SetActive(false);
        Ecran4.SetActive(false);
        Ecran4b.SetActive(false);

        InUi = true;
    }

    public void Active3()
    {
        this.Main.SetActive(false);
        Ecran1.SetActive(false);
        Ecran1b.SetActive(false);
        Ecran2.SetActive(false);
        Ecran3.SetActive(true);
        Ecran4.SetActive(false);
        Ecran4b.SetActive(false);

        InUi = true;
    }

    public void Active4()
    {
        this.Main.SetActive(false);
        Ecran1.SetActive(false);
        Ecran1b.SetActive(false);
        Ecran2.SetActive(false);
        Ecran3.SetActive(false);
        Ecran4.SetActive(true);
        Ecran4b.SetActive(false);

        InUi = true;
    }

    public void Active4b()
    {
        this.Main.SetActive(false);
        Ecran1.SetActive(false);
        Ecran1b.SetActive(false);
        Ecran2.SetActive(false);
        Ecran3.SetActive(false);
        Ecran4.SetActive(false);
        Ecran4b.SetActive(true);

        InUi = true;
    }

    public void ActiveChrono()
    {
        Chrono.SetActive(true);
        Chrono.GetComponent<ChronoBehaviour>().enabled = true;
    }

    public void CloseChrono()
    {
        Chrono.SetActive(false);
        Chrono.GetComponent<ChronoBehaviour>().enabled = false;
        Run.SetActive(false);
        Stop.SetActive(true);
    }

    public void PushUp()
    {
        StartPushUp.SetActive(false);
        StopPushUp.SetActive(true);
    }

    public void StopPush()
    {
        Verif.SetActive(true);
    }

    public void CloseVerif()
    {
        Verif.SetActive(false);
    }
}
