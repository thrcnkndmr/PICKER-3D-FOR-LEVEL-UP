using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSubject : MonoBehaviour
{
    public static event Action OnScoreChange;

    //Subject  

    public void ScoreOnChanged()
    {
        OnScoreChange?.Invoke();
    }
}
