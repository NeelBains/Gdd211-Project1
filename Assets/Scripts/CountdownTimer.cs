using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public GameObject textbox;
    public int secondsLeft = 30;
    public bool takingaway = false;

    public void Start()
    {
        textbox.GetComponent<Text>().text = "00:" + secondsLeft + " Left";
    }

    public void Update()
    {
        if (takingaway == false && secondsLeft >0)
        {
            StartCoroutine(Timer());
        }

        if (secondsLeft==0)
        {
            SceneManager.LoadScene("LoseScreen");
        }
    }

    IEnumerator Timer()
    {
        takingaway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if (secondsLeft < 10)
        {
            textbox.GetComponent<Text>().text = "00:0" + secondsLeft + " Left";
        }
        else
        {
            textbox.GetComponent<Text>().text = "00:" + secondsLeft + " Left";
        }
        takingaway = false;
    }

}
