using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpBehaviour : MonoBehaviour {

    public List<Sprite> rewards;

    static int index = 0;

    public GameObject Reward1;
    public GameObject Reward2;

    public void Init()
    {
        Reward1.GetComponent<UnityEngine.UI.Button>().image.sprite = rewards[index++];
        Reward2.GetComponent<UnityEngine.UI.Button>().image.sprite = rewards[index++];
    }

    public void ToReward1()
    {
        RoomManager.Instance.NextRoom(0);
        RoomManager.Instance.UpIndex();
        UIManager.Instance.ClosePopUp();
    }

    public void ToReward2()
    {
        RoomManager.Instance.NextRoom(1);
        UIManager.Instance.ClosePopUp();
    }

}
