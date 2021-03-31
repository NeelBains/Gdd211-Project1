using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockController : MonoBehaviour
{

    [SerializeField] Text codeText;
    string codeTextValue = "";
    [SerializeField] GameObject Door1;
    [SerializeField] GameObject Door2;
    [SerializeField] GameObject Door3;

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "1234")
        {
            Door1.GetComponent<Animator>().SetBool("Open",true);

        }
        if (codeTextValue == "1337")
        {
            Door2.GetComponent<Animator>().SetBool("Open2", true);

        }
        if (codeTextValue == "6824")
        {
            Door3.GetComponent<Animator>().SetBool("Open3", true);

        }

        if (codeTextValue.Length >= 4)
            codeTextValue = "";
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }

}