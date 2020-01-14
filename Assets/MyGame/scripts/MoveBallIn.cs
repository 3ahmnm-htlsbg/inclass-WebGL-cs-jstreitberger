using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBallIn : MonoBehaviour
{
    //public GameObject PosBallTopLeft;
    //public GameObject PosBallTopRight;
    //public GameObject PosBallBottomLeft;
    //public GameObject PosBallBottomRight;

    [SerializeField] private GameObject[] BallPositions;
    [SerializeField] private GameObject ball;

   public void MoveTheBall()
    {
        Debug.Log(Random.Range(0, 1));
    }

   
}
