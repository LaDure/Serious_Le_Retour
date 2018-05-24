using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChronoBehaviour : MonoBehaviour {

    public float Timer { get; set; }

    public UnityEngine.UI.Text text;

	// Use this for initialization
	void Start ()
    {
        if (GameManager.Instance.day == 1)
            Timer = 11;
        else
            Timer = 21;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            UIManager.Instance.CloseChrono();
            Timer = 11;
        }
            
        text.text = ((int)Timer).ToString();
	}


}
