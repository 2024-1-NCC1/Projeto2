using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    private int score;

    void Awake()
    {
        // Certifique-se de que s� exista uma inst�ncia do ScoreManager
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Inicializa a pontua��o e atualiza o texto da UI
        score = 0;
        UpdateScoreText();
    }

    public void AddScore(int scoreItem)
    {
        score += scoreItem;
        UpdateScoreText();
    }

    public void MinusScore(int scoreItem)
    {
        score -= scoreItem;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        // Atualiza o texto da UI com a pontua��o atual
        scoreText.text = "Score: " + score;
    }
}