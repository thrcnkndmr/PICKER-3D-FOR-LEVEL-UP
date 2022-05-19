using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    [CreateAssetMenu(fileName = "New Ball Type", menuName = "Ball Type")]
    public class BallType : ScriptableObject
    {
        public Color ballColor = Color.yellow;
        public Vector3 ballScale = Vector3.one;

    }
