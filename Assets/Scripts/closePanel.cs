using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closePanel : MonoBehaviour
{
    [SerializeField] GameObject panel;

    public void close()
    {
        panel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
