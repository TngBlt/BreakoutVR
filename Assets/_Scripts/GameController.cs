using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

	public Camera camera;
		
	void OnEnable()
	{
		if (PupilTools.IsConnected)
		{
			// Show the three colored dots to visualize the gaze
			PupilGazeTracker.Instance.StartVisualizingGaze ();		
			// Subscribe to gaze
			PupilTools.SubscribeTo("Gaze");
			
			// Cast a Ray
			Ray ray = camera.ViewportPointToRay(PupilData._2D.GazePosition);
			
			// print the gaze position in the world
			print(PupilData._2D.GazePosition.ToString("F2"));
			
		}
	}
}
