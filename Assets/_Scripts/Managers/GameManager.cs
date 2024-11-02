using UnityEngine;

namespace _Scripts
{
    public class GameManager : MonoBehaviour
    {

        public GameObject MoonLight;
        public GameObject SunLight;
        
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log("Game Started");
            
            InvokeRepeating(nameof(ChangePassiveLight), 10, 20);
        }

        public void ChangePassiveLight()
        {
            Debug.Log("ChangePassiveLight");
            MoonLight.SetActive(!MoonLight.activeSelf);
            SunLight.SetActive(!SunLight.activeSelf);
        }
        
        public void GameOver()
        {
            Time.timeScale = 0;
        }
    }
}
