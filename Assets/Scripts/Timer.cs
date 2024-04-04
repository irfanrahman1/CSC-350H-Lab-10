using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float interval;
    private bool isRunning;
    private bool isStarted;
    private float elapsedTime;
    private float startTime; // Added a start time variable

    // Properties
    public float Interval
    {
        get => interval;
        set => interval = value;
    }
    public bool IsRunning => isRunning;
    public bool IsStarted => isStarted;
    public float ElapsedTime
    {
        get => elapsedTime;
        set => elapsedTime = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Initialize start time
        startTime = Time.time;
    }

    public void StartTimer()
    {
        // Start the timer
        isStarted = true;
        isRunning = true;
    }

    public void Reset()
    {
        // Reset the timer
        elapsedTime = 0;
        isRunning = false;
        isStarted = false;
    }

    public void Pause()
    {
        // Pause the timer
        isRunning = false;
    }

    public void Resume()
    {
        // Resume the timer
        isRunning = true;
        startTime = Time.time; // Update start time when resuming
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            float deltaTime = Time.deltaTime;
            elapsedTime += deltaTime;

            // Check if the timer finishes
            if (elapsedTime >= interval)
            {
                Console.WriteLine("Timer finished!");
                isRunning = false;
                Reset(); // Reset the timer
            }
        }
    }


    public bool IsFinished()
    {
        // Check if the timer has finished
        return !IsRunning;
    }
}
