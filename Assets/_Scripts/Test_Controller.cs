using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Controller : MonoBehaviour {
	
	void OnEnable()
	{
		if (PupilTools.IsConnected)
		{
			// Show the three colored dots to visualize the gaze
			PupilGazeTracker.Instance.StartVisualizingGaze ();		
			// Subscribe to gaze
			PupilTools.SubscribeTo("Gaze");
			// print the gaze position in the world
			print(PupilData._2D.GazePosition.ToString("F2"));
			
		}
	}
}
