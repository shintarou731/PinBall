using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            foreach (Touch t in Input.touches)
            {
                if (t.phase != TouchPhase.Ended && t.phase != TouchPhase.Canceled)
                {
                    Debug.Log("x=" + t.position.x + " y=" + t.position.y);
                }
            }
        }
    }
}
