using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckIsButtonPushed();
    }

    public void ResumeGame()
    {
        Application.LoadLevel(1);
    }

    public void EndGame()
    {
        Application.LoadLevel(0);
    }

    public void CheckIsButtonPushed()
    {
        if (Input.GetButton("ShowMenu"))
        {
            Application.LoadLevel(1);
        }
    }
}
