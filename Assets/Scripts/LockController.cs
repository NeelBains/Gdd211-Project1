using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockController : MonoBehaviour
{

    [SerializeField]
    Text codeText;
    string codeTextValue = "";
    [SerializeField]
    GameObject Door1;

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "1234")
        {
            Door1.GetComponent<Animator>().SetBool("Open",true);

        }

        if (codeTextValue.Length >= 4)
            codeTextValue = "";
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }

}