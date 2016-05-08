using UnityEngine;
using System.Collections;

public class WaitForShowMenu : MonoBehaviour
{
    bool paused;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        CheckIsButtonPushed();
    }

    public void CheckIsButtonPushed()
    {
        if (Input.GetButtonUp("ShowMenu"))
        { 
            if (!StateSingleton.Instance.isPaused())
            {
                Time.timeScale = 0;
                StateSingleton.Instance.setPaused(true);
                StateSingleton.Instance.gameTime.Stop();
                Application.LoadLevelAdditiveAsync(2);
            }
            else
            {
                Time.timeScale = 1;
                StateSingleton.Instance.setPaused(false);
                StateSingleton.Instance.gameTime.Start();
                Application.UnloadLevel(2);
            }
        }
    }
}
