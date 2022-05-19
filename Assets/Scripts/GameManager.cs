using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    PlayerController player;
    private int lastLevel;
    public int level =1;
    public UIController uiController;

    private void Start()
    {    
          player = PlayerController.instance;
        uiController.EditLevelText(PlayerPrefs.GetInt("lastLevel") + 1);
    }

    public void EndGameButtonAction()
    {
        lastLevel++;
        if (player.isLevelDone)
        {

            if (PlayerPrefs.GetInt("Level") < 2)
            {
                PlayerPrefs.SetInt("lastLevel", PlayerPrefs.GetInt("lastLevel") + 1);
                PlayerPrefs.SetInt("Level", (PlayerPrefs.GetInt("Level") + 1));
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            }

            else
            {
                PlayerPrefs.SetInt("lastLevel", PlayerPrefs.GetInt("lastLevel") + 1);
                PlayerPrefs.SetInt("Level", 0);
                SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
            }
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    }
