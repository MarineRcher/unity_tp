using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MoveToGamesScene()
    {
        SceneManager.LoadScene("games");
    }

    public void MoveToCreditsScene()
    {
        SceneManager.LoadScene("credits");
    }
    public void MoveToMenuScene()
    {
        SceneManager.LoadScene("menu");
    }
    
    public void Quit(){
        Application.Quit();
    }
}
