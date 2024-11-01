using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Scripts.Managers
{
    public class MenuUIManager: MonoBehaviour
    {
        public void StartGame()
        {
            SceneManager.LoadScene("BeachScene");
        }
    }
}