using UnityEngine;

public class FinishTrigger : MonoBehaviour

{
    public UIController uiController;
    PlayerController player;

    private void Start()
    {
        player = PlayerController.instance;
    }



    void OnTriggerEnter()
    {
        uiController.CompleteLevel();
        player.isLevelDone = true;
    }
}