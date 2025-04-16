using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Anything in the if statement will be run when you hit "esc"
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
