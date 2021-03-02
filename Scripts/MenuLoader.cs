using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{
    public AudioSource audioSource;
    private GameManager gameManager;
    // Start is called before the first frame update
   public void PlayGame ()
    {
        audioSource.Play();
        SceneManager.LoadScene("Game");
        
    }
    public void QuitGame()
    {
        audioSource.Play();
        Debug.Log("Quit");
        Application.Quit();
    }
    public void Menu()
    {
        audioSource.Play();
        SceneManager.LoadScene("Start Menu");
    }
    public void GameOver()
    {
        
        SceneManager.LoadScene("GameOverMenu");

    }
}
