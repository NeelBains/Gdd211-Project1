using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboLock : Interactable
{
    [SerializeField]GameObject panel;

    public override void Hit()
    {
        panel.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("combo lock");
    }
}
