using UnityEngine;

public class Example : MonoBehaviour
{
    public string personWeAreTalkingTo;
    private int counter;
    
    void Start()
    {
        counter = 1;
        print("Hello " + personWeAreTalkingTo + "! My name is " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        print(counter);
        counter += 1;
    }
}
