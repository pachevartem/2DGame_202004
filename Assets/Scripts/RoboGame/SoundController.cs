using System;
using System.Collections.Generic;
using UnityEngine;

namespace RoboGame
{
    [RequireComponent(typeof(AudioSource))]
    public class SoundController: MonoBehaviour
    {

        public static SoundController Instance = null;
        
        //Касеты
        public List<AudioClip> clips;
        //0 - kill 
        //1 - Music Game

        //магнитофон
        private AudioSource mafon;

        void Singleton()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }

            DontDestroyOnLoad(gameObject);
        }

        private void Awake()
        {
            
            Singleton();

            if (mafon == null)
            {
                mafon = GetComponent<AudioSource>();
            }
            StartGameTheme();


            Enemy.Kill += KillSound;

        }

        
        public void StartGameTheme()
        {
            mafon.clip = clips[1];
            mafon.Play();
        }

        void KillSound()
        {
            // mafon.clip = clips[0];
            // mafon.Play();
            AudioSource.PlayClipAtPoint(clips[0],Camera.main.transform.position,5);
            
        }


        private void OnDisable()
        {
            Enemy.Kill -= KillSound;
        }
    }
}