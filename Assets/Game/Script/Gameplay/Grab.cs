using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    public GameObject myHand;
    public bool onHand = false;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GrabItem();
    }

    public void GrabItem()
    {
        if (Input.GetKeyDown(KeyCode.F) && onHand == false)
        {
            ball.transform.SetParent(myHand.transform);
            ball.transform.localPosition = new Vector3(0, myHand.transform.localPosition.y, 0);
            onHand = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && onHand == true)
        {
            ball.transform.SetParent(null);
            ball.transform.localPosition = new Vector3(this.transform.localPosition.x+0.32f, 0.25f, this.transform.localPosition.z+1.25f);
            onHand = false;
        }
    }
}
