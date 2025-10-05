using UnityEngine;

public class Example : MonoBehaviour
{
    public string message;
    private int counter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        counter = 1;
        print(message);
    }

    // Update is called once per frame
    void Update()
    {
        print(counter);
        counter += 1;
    }
}
