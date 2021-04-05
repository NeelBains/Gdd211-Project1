using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
            SceneManager.LoadScene("end");
    }
}
