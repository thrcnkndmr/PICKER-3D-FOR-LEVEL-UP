using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreObserver : MonoBehaviour

//Observer
{
    public Transform player;
    public Text scoreText;

    private void Start()
    {
        scoreText.text = "0";
        ScoreSubject.OnScoreChange += Update;
    }

    public void Update() => scoreText.text = player.position.z.ToString("0");
}
