using UnityEngine;
using UnityEngine.Events;

public class Invoker : MonoBehaviour
{
    private MessageEvent messageEvent = new MessageEvent();
    private Timer timer;

    void Awake()
    {
        // Creates an instance of the event object in your new field.
        messageEvent = new MessageEvent();
    }

    public void AddNoArgumentListener(UnityAction listener)
    {
        // Adds a listener to the event.
        messageEvent.AddListener(listener);
    }

    void Start()
    {
        // Ensure there's a Timer component attached to the GameObject.
        timer = gameObject.GetComponent<Timer>();
        if (timer == null)
        {
            timer = gameObject.AddComponent<Timer>();
        }
        timer.Interval = 2; // Set the timer's interval to 2 seconds.
        timer.StartTimer();
    }

    void Update()
    {
        // If the timer has finished, invoke the event and restart the timer.
        if (timer.IsFinished())
        {
            messageEvent.Invoke();
            timer.Reset();
            timer.StartTimer();
        }
    }
}
