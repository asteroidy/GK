using UnityEngine;
using System.Collections;

public class SpaceShipControl : MonoBehaviour {

    public static Vector3 currentPosition;
    private float verticalSize;
    private float horizontallSize;
	// Use this for initialization
	void Start () {
        transform.position = StateSingleton.Instance.shipPosition;
        verticalSize = Camera.main.orthographicSize;
        horizontallSize = verticalSize * Screen.width / Screen.height;
        Debug.LogWarning("Size vert is: " + verticalSize);
        Debug.LogWarning("Size horz is: " + horizontallSize);
	}
	
	// Update is called once per frame
	void Update () {
        if (!StateSingleton.Instance.isPaused())
        {
            checkDirectionOfMove();
        }
    }

    public void checkDirectionOfMove()
    {
        if (Input.GetKey("a"))
        {
            currentPosition = (getPos().x < -16.58 ?  getPos() : Vector3.MoveTowards(transform.position,transform.position + new Vector3(-1,0,0),0.25f));
            setPos(currentPosition);
        }
        if (Input.GetKey("w"))
        {
            currentPosition = (getPos().y > 5.0 ? getPos() : Vector3.MoveTowards(transform.position, transform.position + new Vector3(0, 1, 0), 0.25f));
            setPos(currentPosition);
        }
        if (Input.GetKey("s"))
        {
            currentPosition = (getPos().y < -5 ? getPos() : Vector3.MoveTowards(transform.position, transform.position + new Vector3(0, -1, 0), 0.25f));
            setPos(currentPosition);
        }
        if (Input.GetKey("d"))
        {
            currentPosition = (getPos().x > 16.7 ? getPos() : Vector3.MoveTowards(transform.position, transform.position + new Vector3(1, 0, 0), 0.25f));
            setPos(currentPosition);
        }
    }

    private Vector3 getPos() {
        return transform.position;
    }

    private void setPos(Vector3 currentPosition)
    {
        StateSingleton.Instance.shipPosition = transform.position;
        transform.position = currentPosition;
    }
}
