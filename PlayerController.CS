using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject mainCamera;
    private float speed = 1f;
    private float turnSpeed = 1f;
    public float horizontalInput;
    public float forwardInput;
    public GameObject EventSystem;
    private GameClock refScript;

    private
    // Start is called before the first frame update
    void Start()
    {
        refScript = EventSystem.GetComponent<GameClock>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (refScript.canMove == false && (horizontalInput > 0 || forwardInput > 0) && refScript.timerIsRunning == true && refScript.beatGame == false)
        {
            refScript.gameOver = true;
        }

        if (refScript.gameOver == true && refScript.beatGame == false)
        {
            Debug.Log("You're out!");
            refScript.timerIsRunning = false;
            refScript.failedLabel.gameObject.SetActive(true);
        }

        if (transform.position.x > -42 && refScript.gameOver == false)
        {
            // winner
            refScript.beatGame = true;
            refScript.timerIsRunning = false;
            refScript.winLabel.gameObject.SetActive(true);
        }

        if (refScript.timerIsRunning == true && refScript.gameOver == false)
        {
            forwardInput = Input.GetAxis("Vertical");
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
            mainCamera.transform.position = transform.position + new Vector3(-5f, 3f, 0);
        }
        
    }
}
