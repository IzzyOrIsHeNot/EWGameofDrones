using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitListener : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
		// quit if ESC pressed
        if (Input.GetKeyUp(KeyCode.Escape))
		{
			// quit
			Application.Quit();
		}
    }
}
