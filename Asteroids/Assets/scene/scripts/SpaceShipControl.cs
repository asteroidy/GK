using UnityEngine;
using System.Collections;

public class SpaceShipControl : MonoBehaviour {

    GameObject spaceShip;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        checkDirectionOfMove();
	}

    public void checkDirectionOfMove()
    {
        Vector3 currentPosition;
        if (Input.GetKey("a"))
        {
            currentPosition = (getPos().x < -10.58 ?  getPos() : Vector3.MoveTowards(transform.position,transform.position + new Vector3(-1,0,0),0.25f));
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
            currentPosition = (getPos().x > 10.7 ? getPos() : Vector3.MoveTowards(transform.position, transform.position + new Vector3(1, 0, 0), 0.25f));
            setPos(currentPosition);
        }
    }

    private Vector3 getPos() {
        return transform.position;
    }

    private void setPos(Vector3 currentPosition)
    {
        transform.position = currentPosition;
    }
}
