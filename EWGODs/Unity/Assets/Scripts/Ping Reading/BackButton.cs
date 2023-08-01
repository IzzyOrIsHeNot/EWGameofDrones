using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
		// load the sensor placement scene when Escape is pressed
        if (Input.GetKeyUp(KeyCode.Escape))
		{
			Destroy(GameObject.FindWithTag("Sensor Manager"));
			SceneManager.LoadScene("SensorPlacement");
		}
    }
}
