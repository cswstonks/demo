﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DesertHutTrigger: MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SwitchScene();

        }
    }
    void SwitchScene()
    {

        Debug.Log("Switch to cutScene3");
        SceneManager.LoadScene("cutScene3");
    }
}