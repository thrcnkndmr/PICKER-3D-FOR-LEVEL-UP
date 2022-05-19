using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{

    [SerializeField]
    List<GameObject> levelCheckObject = new List<GameObject>();
   [SerializeField] private int checkCounter;

    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (levelCheckObject[checkCounter].GetComponent<BallManager>().levelGoes)
        {
            levelCheckObject[checkCounter].GetComponent<BallManager>().levelGoes = false;
            anim.SetBool("checkpointok", true);
            
        }

    }
}
