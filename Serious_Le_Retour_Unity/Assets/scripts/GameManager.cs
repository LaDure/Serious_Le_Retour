using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text text;

    private int day = 1;

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        this.UpdateText();
    }

    private void UpdateText()
    {
        text.text = "Jour " + day.ToString();
    }

    public void NextDay()
    {
        if (day + 1 <= 7)
        {
            ++day;
            RoomManager.Instance.NextRoom();
            this.UpdateText();
        }                    
    }

    public void PreviousDay()
    {
        if (day - 1 > 0)
        {
            --day;
            RoomManager.Instance.PreviousRoom();
            this.UpdateText();
        }        
    }
}
