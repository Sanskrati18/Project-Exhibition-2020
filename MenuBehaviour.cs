using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehaviour : MonoBehaviour
{
    public void triggerMenuBehaviour(int i)
    {
        switch (i)
        {
            default:
            case (0):
                SceneManager.LoadScene("The World/4");
                break;
            case (1):
                SceneManager.LoadScene("Food order/1");
                break;
            case (2):
                Application.Quit();
                break;
            case (3):
                SceneManager.LoadScene("Food order/2");
                break;
            case (4):
                SceneManager.LoadScene("Main");
                break;
            case (5):
                SceneManager.LoadScene("Food order/3");
                break;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
