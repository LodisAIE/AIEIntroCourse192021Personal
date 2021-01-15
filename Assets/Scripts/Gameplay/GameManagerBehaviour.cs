using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _swarm;
    [SerializeField]
    private HealthBehavior _playerHealth;
    [SerializeField]
    private GameObject _gameOverScreen;
    [SerializeField]
    private Text _gameOverText;
    private bool _gameOver;
    
    public void RestartGame()
    {
        //Loads teh first scene in the buid.
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        //Closes the aplication window
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        //Check if the swarm has no enemies attached and if the game hasn't already ended
        if (_swarm.transform.childCount == 0 & !_gameOver)
        {
            //Turns on the canvas and updates the text
            _gameOverScreen.SetActive(true);
            _gameOverText.text = "You Win!!!";
            _gameOverText.color = Color.green;
            
            _gameOver = true;
        }
        //Check if the player is alive and if the game hasn't already ended
        else if (!_playerHealth.isAlive && !_gameOver)
        {
            //Turns on the canvas and updates the text
            _gameOverScreen.SetActive(true);
            _gameOverText.text = "You Lose";
            _gameOverText.color = Color.red;

            _gameOver = true;
        }
    }
}
