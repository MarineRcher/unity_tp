using UnityEngine;
using TMPro;
public class Collect : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private int score = 0;
    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("target"))
        {
            AddScore();
            Destroy(other.gameObject);
        }
    }
    void AddScore()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }
}
