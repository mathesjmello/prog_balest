﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Script
{
    public class DamegeManeger: MonoBehaviour
    {
        public Text LifeCount;
        public GameObject EndCanvas;
        public int Life= 30;

        public void TakeDamege(int damege)
        {
            Life -= damege;
            if (Life<=0)
            {
                EndCanvas.SetActive(true);
                Time.timeScale = 0;
            }
        }

        private void Update()
        {
            LifeCount.text = "Life:"+Life.ToString();
        }

        public void Restar()
        {
            SceneManager.LoadScene(0);
        }

        public void Quit()
        {
            SceneManager.LoadScene(1);
        }
        
    }
}