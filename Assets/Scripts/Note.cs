using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : Interactable
{
    [SerializeField] GameObject panel;
    public override void Hit()
    {
        panel.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("Note");
    }
}
