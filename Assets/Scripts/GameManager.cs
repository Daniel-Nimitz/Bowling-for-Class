using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int currentScore;
    public float winDelaySeconds;

    PlayerController playerController;

    [SerializeField] TextMeshProUGUI scoreText;

    private Pin[] _currentPins = new Pin[0];
    private Ball _currentBall;

    [SerializeField] Transform _pinPosition;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerController.wasBallThrown)
        {
            //Player has not thrown ball
        }
    }

    public void PinKnockedDown()
    {
        GivePoint();
        Debug.Log("Current Score is: " + currentScore);
        
        //Called when each pin is hit and pin head comes in contact with floor
    }

    public void BallKnockedDown()
    {
        //Called when ball gets into pit
        _currentBall = null;
    }

    public void BallThrown(Ball ball)
    {
        //Reference ball that is thrown
        _currentBall = ball;
    }

    private bool CheckIfPiecesAreStatic()
    {
        foreach (var pin in _currentPins)
        {
            if (pin != null && pin.DidPinMove())
            {
                return false;
            }
        }
        var ballStatus = _currentBall == null || !_currentBall.DidBallMove();
        return ballStatus; //Checks for Pin Movement
    }

    private void SetupFrame()
    {
        //Used to setup frame
    }

    private void FinishThrow()
    {
        //Called when we complete a throw
    }

    public void SetupThrow()
    {
        //Creates initial conditions to allow player throw ball
    }
    //This counts gives a point to the player, updates the score UI, and then checks if the player has won if the player has knocked over all the pins then I call WinDelay
    public void GivePoint() {
        currentScore++;
        scoreText.text = "Score: " + currentScore;
        if (currentScore >= 10) {
            

            StartCoroutine(WinDelay());
            
        }
    //check to see if player has won the game
    //if won the game then cause scene to restart
    
    }

    //WinDelay is used to wait a short time after all 10 pins are knocked down then reload the scene
    IEnumerator WinDelay() {
        Debug.Log("Player Won the Game");
        yield return new WaitForSeconds(winDelaySeconds);
        SceneManager.LoadScene("SampleScene");
    }

}
