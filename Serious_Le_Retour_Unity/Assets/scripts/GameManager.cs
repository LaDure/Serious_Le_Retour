using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private int day = 1;
    private int maxDay = 8;

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        UIManager.Instance.UpdateText(day);
    }

    public void NextDay()
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
    }
}
