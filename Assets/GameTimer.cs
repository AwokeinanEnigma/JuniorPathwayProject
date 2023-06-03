using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class GameTimer : MonoBehaviour
    {
        public float timer;
        public int score;
        public Text text;
        public Text scoreText;

        public Text goScoreText;
        public Text goNameText;
        public Text go;

        public static GameTimer Instance;
        public GameObject image;
        public string GameOverScene;
        public void Awake()
        {
            Instance = this;
        }
        
        public void Update()
        {
            timer -= Time.deltaTime;
            GameOverScene = ((int)timer).ToString();
            text.text = GameOverScene;
            scoreText.text = "Score: " + score;
            if (timer <= 0)
            {
                Debug.Log("Game over!");
                goScoreText.gameObject.SetActive(true);
                goScoreText.text = "Final Score: " + score;
                go.gameObject.SetActive(true);
                goNameText.gameObject.SetActive(true);
                goNameText.text = "Name: " + PlayerPrefs.GetString("Name");
                image.SetActive(true);
            }
        }
        
        public static  void AddTime(float time)
        {
            Instance.timer += time;
        }
        
        public static void AddScore(int score)
        {
            Instance.score += score;
        }
    }
}