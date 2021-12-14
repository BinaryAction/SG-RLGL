using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GameClock : MonoBehaviour
{
    public TextMeshProUGUI timerLabel;
    public TextMeshProUGUI redLightLabel;
    public TextMeshProUGUI greenLightLabel;
    public TextMeshProUGUI failedLabel;
    public TextMeshProUGUI winLabel;
    public AudioSource introSound;
    public AudioSource greenLightSound;
    public AudioSource redLightSound;
    private float timeRemaining = 60 * 3;
    public bool timerIsRunning = false;
    public bool gameOver = false;
    public GameObject Enemy;
    public bool canMove = true;
    public bool beatGame = false;

    private float randTime = 0f;

    private void Start()
    {
        // Starts the timer automatically
        introSound.Play();
        Wait(3, () => {
            timerIsRunning = true;
            Debug.Log("5 seconds is lost forever");
            greenLightSound.Play();
            greenLightLabel.gameObject.SetActive(true);
            timerLabel.gameObject.SetActive(true);
            // RED LIGHT //
            randTime = UnityEngine.Random.Range(3.0f, 10.0f);
            Wait(randTime, () =>
            {
                greenLightLabel.gameObject.SetActive(false);
                redLightSound.Play();
                redLightLabel.gameObject.SetActive(true);
                Enemy.gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
                canMove = false;
                if (timerIsRunning == false)
                {
                    return;
                }
                // END RED LIGHT //
                randTime = UnityEngine.Random.Range(3.0f, 7.0f);
                Wait(randTime, () =>
                {
                    if (timerIsRunning == false)
                    {
                        return;
                    }
                    // GREEN LIGHT //
                    redLightLabel.gameObject.SetActive(false);
                    greenLightSound.Play();
                    greenLightLabel.gameObject.SetActive(true);
                    Enemy.gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
                    canMove = true;
                    // END GREEN LIGHT
                    // PUT LINE UNDER HERE
                    // RED LIGHT //
                    randTime = UnityEngine.Random.Range(3.0f, 10.0f);
                    Wait(randTime, () =>
                    {
                        greenLightLabel.gameObject.SetActive(false);
                        redLightSound.Play();
                        redLightLabel.gameObject.SetActive(true);
                        Enemy.gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
                        canMove = false;
                        if (timerIsRunning == false)
                        {
                            return;
                        }
                        // END RED LIGHT //
                        randTime = UnityEngine.Random.Range(3.0f, 7.0f);
                        Wait(randTime, () =>
                        {
                            if (timerIsRunning == false)
                            {
                                return;
                            }
                            // GREEN LIGHT //
                            redLightLabel.gameObject.SetActive(false);
                            greenLightSound.Play();
                            greenLightLabel.gameObject.SetActive(true);
                            Enemy.gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
                            canMove = true;
                            // END GREEN LIGHT
                            // PUT LINE UNDER HERE
                            // RED LIGHT //
                            randTime = UnityEngine.Random.Range(3.0f, 10.0f);
                            Wait(randTime, () =>
                            {
                                greenLightLabel.gameObject.SetActive(false);
                                redLightSound.Play();
                                redLightLabel.gameObject.SetActive(true);
                                Enemy.gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
                                canMove = false;
                                if (timerIsRunning == false)
                                {
                                    return;
                                }
                                // END RED LIGHT //
                                randTime = UnityEngine.Random.Range(3.0f, 7.0f);
                                Wait(randTime, () =>
                                {
                                    if (timerIsRunning == false)
                                    {
                                        return;
                                    }
                                    // GREEN LIGHT //
                                    redLightLabel.gameObject.SetActive(false);
                                    greenLightSound.Play();
                                    greenLightLabel.gameObject.SetActive(true);
                                    Enemy.gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
                                    canMove = true;
                                    // END GREEN LIGHT
                                    // PUT LINE UNDER HERE
                                    // RED LIGHT //
                                    randTime = UnityEngine.Random.Range(3.0f, 10.0f);
                                    Wait(randTime, () =>
                                    {
                                        greenLightLabel.gameObject.SetActive(false);
                                        redLightSound.Play();
                                        redLightLabel.gameObject.SetActive(true);
                                        Enemy.gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
                                        canMove = false;
                                        if (timerIsRunning == false)
                                        {
                                            return;
                                        }
                                        // END RED LIGHT //
                                        randTime = UnityEngine.Random.Range(3.0f, 7.0f);
                                        Wait(randTime, () =>
                                        {
                                            if (timerIsRunning == false)
                                            {
                                                return;
                                            }
                                            // GREEN LIGHT //
                                            redLightLabel.gameObject.SetActive(false);
                                            greenLightSound.Play();
                                            greenLightLabel.gameObject.SetActive(true);
                                            Enemy.gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
                                            canMove = true;
                                            // END GREEN LIGHT
                                            // PUT LINE UNDER HERE
                                            // RED LIGHT //
                                            randTime = UnityEngine.Random.Range(1.0f, 10.0f);
                                            Wait(randTime, () =>
                                            {
                                                greenLightLabel.gameObject.SetActive(false);
                                                redLightSound.Play();
                                                redLightLabel.gameObject.SetActive(true);
                                                Enemy.gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
                                                canMove = false;
                                                if (timerIsRunning == false)
                                                {
                                                    return;
                                                }
                                                // END RED LIGHT //
                                                randTime = UnityEngine.Random.Range(3.0f, 7.0f);
                                                Wait(randTime, () =>
                                                {
                                                    if (timerIsRunning == false)
                                                    {
                                                        return;
                                                    }
                                                    // GREEN LIGHT //
                                                    redLightLabel.gameObject.SetActive(false);
                                                    greenLightSound.Play();
                                                    greenLightLabel.gameObject.SetActive(true);
                                                    Enemy.gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
                                                    canMove = true;
                                                    // END GREEN LIGHT
                                                    // PUT LINE UNDER HERE
                                                    // RED LIGHT //
                                                    randTime = UnityEngine.Random.Range(1.0f, 10.0f);
                                                    Wait(randTime, () =>
                                                    {
                                                        greenLightLabel.gameObject.SetActive(false);
                                                        redLightSound.Play();
                                                        redLightLabel.gameObject.SetActive(true);
                                                        Enemy.gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
                                                        canMove = false;
                                                        if (timerIsRunning == false)
                                                        {
                                                            return;
                                                        }
                                                        // END RED LIGHT //
                                                        randTime = UnityEngine.Random.Range(3.0f, 7.0f);
                                                        Wait(randTime, () =>
                                                        {
                                                            if (timerIsRunning == false)
                                                            {
                                                                return;
                                                            }
                                                            // GREEN LIGHT //
                                                            redLightLabel.gameObject.SetActive(false);
                                                            greenLightSound.Play();
                                                            greenLightLabel.gameObject.SetActive(true);
                                                            Enemy.gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
                                                            canMove = true;
                                                            // END GREEN LIGHT
                                                            // PUT LINE UNDER HERE

                                                        });
                                                    });
                                                });
                                            });
                                        });
                                    });
                                });
                            });
                        });
                    });
                });
            });
        });
        
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                float minutes = Mathf.FloorToInt(timeRemaining / 60);
                float seconds = Mathf.FloorToInt(timeRemaining % 60);
                //timerLabel.text = timeRemaining.ToString();
                if (seconds < 10)
                {
                    timerLabel.text = minutes.ToString() + ":0" + seconds.ToString();
                } else
                {
                    timerLabel.text = minutes.ToString() + ":" + seconds.ToString();
                }
                
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                gameOver = true;
                timerIsRunning = false;
                timerLabel.text = "0:00";
            }
        }
    }
    public void Wait(float seconds, Action action)
    {
        StartCoroutine(_wait(seconds, action));
    }
    IEnumerator _wait(float time, Action callback)
    {
        yield return new WaitForSeconds(time);
        callback();
    }
}
