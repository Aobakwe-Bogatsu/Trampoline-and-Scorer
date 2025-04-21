using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField]
    private int score = 0;
    public int pointsPerCatch = 10;
    public TextMeshProUGUI txtScore;
    public Transform[] locations;
    public int moveInterval = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Relocate", 0f, moveInterval); //calls 'Relocate' method in 0 secs, then repeatedly in 2secs.  
    }
    //This method is public so that it can be accessed
    public int Scorez(int theScore)  //this method receives a parameter (theScore) to update the 'score' (the current score) that'll be displayed
    {
        score += theScore; // MEANS: whatever the current score is, ADD the score received. This calc. works bc it can add a -ve score received.
        txtScore.text = "SCORE:" + score.ToString(); // this line displays & update the score text on the scene. txtScore -> the variable name of the text in the scene

        return score;
    }

    void OnCollisionEnter(Collision collision) //MEANS: when a game object tagged 'Cube' collides with the scorer, 10 points are added to the score
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            Scorez(pointsPerCatch);
        }   

    }

    void Relocate() //This method moves the 'ScoreZone' around to random positions. [it does that throught the array of locations]
    {
        int newPos = Random.Range(0, 3); 
        this.transform.position = locations[newPos].position;  // values are randomly generated from 0 - 3, including 0 & 3. They are then stored in 'newPos'
    }   //The last line equates the new position to the position intthe inspector.
}
