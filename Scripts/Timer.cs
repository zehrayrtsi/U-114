using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float delay = 85f;

    private void Start()
    {
        Invoke("LoadLevel1", delay);
    }

    private void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }
}
