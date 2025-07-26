using UnityEngine;
using TMPro;
using System.Collections;

public class Collect : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private TextMeshProUGUI timerText;

    private int score = 0;
    private float timerDuration = 60f;
    private float currentTime;
    private int targetScore = 6; 
    private bool gameEnded = false; 
    private Canvas winnerCanvas;
    private Canvas gameOverCanvas;
    private Canvas resultsCanvas;


    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        timerText = GameObject.Find("TimerText")?.GetComponent<TextMeshProUGUI>();
        winnerCanvas = GameObject.Find("Winner")?.GetComponentInParent<Canvas>();
        gameOverCanvas = GameObject.Find("GameOver")?.GetComponentInParent<Canvas>();
        resultsCanvas = GameObject.Find("Results")?.GetComponentInParent<Canvas>();
        winnerCanvas.gameObject.SetActive(false);
        gameOverCanvas.gameObject.SetActive(false);

        currentTime = timerDuration;
        StartCoroutine(CountdownTimer());
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("target") && !gameEnded)
        {
            AddScore();
            Destroy(other.gameObject);
        }
    }

    void AddScore()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();

        if (score >= targetScore)
        {
            Winner();
        }
    }

    private IEnumerator CountdownTimer()
    {
        while (currentTime > 0 && !gameEnded)
        {
            UpdateTimerDisplay();

            yield return new WaitForSeconds(1f);

            currentTime -= 1f;
        }

        if (!gameEnded)
        {
            currentTime = 0;
            UpdateTimerDisplay();
            GameOver();
        }
    }

    private void UpdateTimerDisplay()
    {
        int seconds = Mathf.FloorToInt(currentTime % 60);
        timerText.text = seconds.ToString() + "\"";
    }

    private void Winner()
    {
        gameEnded = true;
        resultsCanvas.gameObject.SetActive(false);
        winnerCanvas.gameObject.SetActive(true);
        StopAllCoroutines();
    }

    private void GameOver()
    {
        gameEnded = true;
        resultsCanvas.gameObject.SetActive(false);
        gameOverCanvas.gameObject.SetActive(true);

    }
}