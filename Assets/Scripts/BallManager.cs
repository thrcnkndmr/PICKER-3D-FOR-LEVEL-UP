using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;

public class BallManager : MonoBehaviour
{
    [SerializeField] private int _balls;
    [SerializeField] private int _levelballs;
    public UIController uiController;
    public TextMeshPro Counter;
    int CounterCheck = 10;
    int CounterText = 0;
    PlayerController player;
    public bool levelGoes;
    
    
 

    void Start()
    {
        player = PlayerController.instance;
        levelGoes = false;
        _balls = 0;
    }

    
    #region BallCounter
    private void OnTriggerEnter(Collider other)
    {
        _balls++;
        BallEffect(other.gameObject);
        player.waitForCheck = true;
        StartCoroutine(CheckComplete());
    }

    IEnumerator CheckComplete()
    {

        yield return new WaitForSeconds(3f);
        if (_balls >= _levelballs)
        {
            LevelCompleted();
        }
        else
        {
            LevelNotCompleted();
        }
        player.waitForCheck = false;
    }
    public void LevelCompleted()
    {
        levelGoes = true;
        player.isLevelFail = false;
        
    }

    public void LevelNotCompleted()
    {
        levelGoes = false;
        player.isLevelFail = true;
        uiController.LevelFailed();
       
    }

    #endregion

    #region DoTween
    void BallEffect(GameObject Ball)
    {
        Ball.transform.DOScale(0.7f, 0.4f).OnComplete(() =>
        {
            Ball.transform.DOScale(0.01f, 0.2f).OnComplete(() =>
             {
                 Ball.SetActive(false);
             });
        });
    }
    #endregion

    private void Update()
    {
        Counter.text = Mathf.RoundToInt(_balls) + "/" + _levelballs;

    }
}
