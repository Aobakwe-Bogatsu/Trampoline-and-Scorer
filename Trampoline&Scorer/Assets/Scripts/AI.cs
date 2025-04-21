using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour  //This script is used to destroy prefabs when they land below a certain height
{
    public Scorer myScorer;
    public int penaltyForDrop = -2;

    void FixedUpdate()
    {
      if(transform.position.y < 2)
      {
       Destroy(gameObject);

       myScorer.Scorez(penaltyForDrop);

      }   
    }
}
