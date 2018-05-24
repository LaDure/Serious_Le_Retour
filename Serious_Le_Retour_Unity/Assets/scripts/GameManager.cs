using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public int day = 1;
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

    public void NextDay()
    {
        if (day + 1 == 5 || day + 1 == 7 || day + 1 == 8 || day + 1 == 9 || day + 1 == 10 || day + 1 == 11 || day + 1 == 12 || day + 1 == 13 || day + 1 == 15)
        {
            ++day;
            UIManager.Instance.PopUp();
            //UIManager.Instance.UpdateText(day);
        }
        else if (day + 1 < this.maxDay)
        {
            ++day;
            RoomManager.Instance.NextRoom(0);
            //UIManager.Instance.UpdateText(day);
        } 
    }

    /*public void PreviousDay()
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
