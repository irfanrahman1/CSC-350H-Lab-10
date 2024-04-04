using UnityEngine;

public class Listener : MonoBehaviour
{
    void Start()
    {
        // Access the Invoker component and add the PrintMessage method as a listener.
        Invoker invoker = Camera.main.GetComponent<Invoker>();
        if (invoker != null)
        {
            invoker.AddNoArgumentListener(PrintMessage);
        }
        else
        {
            Debug.LogError("Invoker component not found on the main camera.");
        }
    }

    void PrintMessage()
    {
        // Print a message to the Console window.
        Debug.Log("Event triggered at: " + Time.time);
    }
}
