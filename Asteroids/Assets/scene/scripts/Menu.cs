using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //CheckIsButtonPushed();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        StateSingleton.Instance.setPaused(false);
        StateSingleton.Instance.gameTime.Start();
        Application.UnloadLevel(2);
    }

    public void EndGame()
    {
        StateSingleton.Instance.setPaused(false);
        Time.timeScale = 1;
        Application.LoadLevel(0);
    }

    public void CheckIsButtonPushed()
    {
        if (Input.GetButtonUp("ShowMenu"))
        {
            ResumeGame();
        }
    }
}
