using UnityEngine;

namespace Script
{
    public class DamegeManeger: MonoBehaviour
    {
        public GameObject EndCanvas;
        public int Life= 100;

        public void TakeDamege(int damege)
        {
            Life -= damege;
            if (Life<=0)
            {
                EndCanvas.SetActive(true);
                Time.timeScale = 0;
            }
        }
        
    }
}