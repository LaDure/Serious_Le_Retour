using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private int day = 1;
    private int maxDay = 16;
    private int difficultLevel = 0;

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        //UIManager.Instance.UpdateText(day);

        if (isFirstTime())
        {
            UIManager.Instance.ChooseDifficult();
            PlayerPrefs.SetInt("HasPlayed", 1);
        }
        else
        {
            Transform.FindObjectOfType<CameraBehaviour>().Init();
            difficultLevel = PlayerPrefs.GetInt("Difficult");
        }
    }

    private bool isFirstTime()
    {
        return PlayerPrefs.GetInt("HasPlayed") == 0;
    }

   /* public void NextDay()
    {
        if (day + 1 < this.maxDay)
        {
            ++day;
            RoomManager.Instance.NextRoom();
            UIManager.Instance.UpdateText(day);
        }else if(day + 1 == this.maxDay)
        {
            ++day;
            UIManager.Instance.PopUp();
            UIManager.Instance.UpdateText(day);
        }
    }

    public void PreviousDay()
    {
        if(day == maxDay)
        {
            --day;
            UIManager.Instance.UpdateText(day);
        }
        else if (day - 1 > 0)
        {
            --day;
            RoomManager.Instance.PreviousRoom();
            UIManager.Instance.UpdateText(day);
        }        
    }*/

    public void SetDifficult(int level)
    {
        difficultLevel = level;
        PlayerPrefs.SetInt("Difficult", level);
        UIManager.Instance.Close();
        Transform.FindObjectOfType<CameraBehaviour>().Init();
    }

   

}
