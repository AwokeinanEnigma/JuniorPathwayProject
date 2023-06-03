using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class PlayGame : MonoBehaviour
    {
        public void QuitGame()
        {
            Application.Quit();
        }
        
        public TMP_InputField NameInput;
        
        public void StartGame()
        {
            SceneManager.LoadScene("GameScene");
            PlayerPrefs.SetString("Name", NameInput.text);
        }
    }
}