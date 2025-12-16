using UnityEngine;

public class BerzerkManager : MonoBehaviour
{
    public GameObject BerzerkInstance;
    public GameObject NonBerzerkInstance;
    
    private GameObject _currentInstance;

    public void SwitchToBerzerk(float duration)
    {
        BerzerkInstance.transform.position = NonBerzerkInstance.transform.position;
        BerzerkInstance.SetActive(true);
        NonBerzerkInstance.SetActive(false);
        Invoke("SwitchToNonBerzerk", duration);
        
    }
    public void SwitchToNonBerzerk()
    {
        NonBerzerkInstance.transform.position = BerzerkInstance.transform.position;
        BerzerkInstance.SetActive(false);
        NonBerzerkInstance.SetActive(true);
    }

}
