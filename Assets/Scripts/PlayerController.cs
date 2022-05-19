using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int sensitivity;
    private float mouseTempX;
    private float horizontalTempPos;
    private float mouseCurrentX;
    [SerializeField] float speedForward;
    private Vector3 tempTargetPos;
    private Rigidbody _rb;
    public bool isLevelDone;
    public bool isLevelFail;
    public bool waitForCheck;
    public static PlayerController instance;


    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }

        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (!isLevelDone && !isLevelFail && !waitForCheck)
        {



            transform.position += Vector3.forward * speedForward * Time.deltaTime;

            if (Input.GetMouseButtonDown(0))
            {
                mouseTempX = (Input.mousePosition.x / Screen.width) * sensitivity;

                horizontalTempPos = transform.position.x;
            }

            if (Input.GetMouseButton(0))
            {


                mouseCurrentX = (Input.mousePosition.x / Screen.width) * sensitivity;

                tempTargetPos = transform.position;
                tempTargetPos.x = horizontalTempPos + (mouseCurrentX - mouseTempX);
                transform.position = tempTargetPos;
                tempTargetPos = transform.position;
                tempTargetPos.x = Mathf.Clamp(tempTargetPos.x, -1.33f, 1.33f);

                transform.position = tempTargetPos;
            }


        }
    }
}
    


