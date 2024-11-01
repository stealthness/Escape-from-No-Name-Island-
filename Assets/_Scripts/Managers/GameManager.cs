using UnityEngine;

namespace _Scripts
{
    public class GameManager : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log("Game Started");
        }

        public void GameOver()
        {
            Time.timeScale = 0;
        }
    }
}
