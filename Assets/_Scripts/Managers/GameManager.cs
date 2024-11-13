using UnityEngine;

namespace _Scripts.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        


        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
            DontDestroyOnLoad(this);
        }

        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log("GM : Game Started");
        }
        
        public void StartGame()
        {
            Debug.Log("GM : Start Game");
        }


    }
}
