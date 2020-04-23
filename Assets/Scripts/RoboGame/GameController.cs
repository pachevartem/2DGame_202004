using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RoboGame
{
    
    public class GameController : MonoBehaviour
    {
        
        private void Awake()
        {
            ExitDoor.OnFinishLevel += ChangeScene;
        }

        public void ChangeScene()
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            if (currentSceneIndex ==1)
            {
                SceneManager.LoadScene(0);
            }

            if (currentSceneIndex == 0)
            {
                SceneManager.LoadScene(1);
            }
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


        private void OnDisable()
        {
            ExitDoor.OnFinishLevel -= ChangeScene;
        }
    }
}