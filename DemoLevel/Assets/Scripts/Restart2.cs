﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart2 : MonoBehaviour
{

        public void RestartGame()
        {
            Time.timeScale = 1f;
            ScoreScript.scoreValue = 0;

            SceneManager.LoadScene("level2");

        }
   
}
