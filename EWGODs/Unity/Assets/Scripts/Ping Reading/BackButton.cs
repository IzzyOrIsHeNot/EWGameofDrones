using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{

	bool SwappedScenes = false;

	List<SensorConfiguration> ExistingSensors = new List<SensorConfiguration>();

    // Update is called once per frame
    void Update()
    {
		// load the sensor placement scene when Escape is pressed
        if (SwappedScenes)
		{
			SensorManager manager = GameObject.FindWithTag("Sensor Manager").GetComponent<SensorManager>() as SensorManager;
			SensorDropdown dropdown = GameObject.FindWithTag("Sensor Dropdown").GetComponent<SensorDropdown>() as SensorDropdown;
			
			
			foreach(SensorConfiguration config in ExistingSensors)
			{
				manager.SaveSensor(config.id, config);
				dropdown.AddNew(config.id);
			}
			
			Destroy(gameObject);
		}
		else if (Input.GetKeyUp(KeyCode.Escape))
		{
			DontDestroyOnLoad(gameObject);
			
			GameObject manager = GameObject.FindWithTag("Sensor Manager");
			
			foreach(SensorRenderer renderer in manager.GetComponent<SensorManager>().GetSensors())
			{
				renderer.transform.SetParent(transform);
				ExistingSensors.Add(renderer.Config);
			}
			
			Destroy(GameObject.FindWithTag("Sensor Manager"));
			SceneManager.LoadScene("SensorPlacement");
			
			SwappedScenes = true;
		}
    }
}
