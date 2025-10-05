using UnityEngine;

public class Example : MonoBehaviour

{
    public string message;
    private int counter;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(message);
        counter = 1;
    }

    // Update is called once per frame
    void Update()
    {
        print(counter);
        counter += 1;
    }
}
