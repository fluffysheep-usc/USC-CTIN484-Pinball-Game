﻿using UnityEngine;
using UnityEditor;
using System.Collections;

public class SnapToGrid : ScriptableObject
{
	[MenuItem ("GameObject/Snap to Grid %g")]
	static void MenuSnapToGrid()
	{
		Transform[] transforms = Selection.GetTransforms(SelectionMode.TopLevel | SelectionMode.OnlyUserModifiable);
		
		float gridx = .16f;
		float gridy = .16f;
		float gridz = .16f;
		
		foreach (Transform transform in transforms)
		{
			Vector3 newPosition = transform.position;
			newPosition.x = Mathf.Round(newPosition.x / gridx) * gridx;
			newPosition.y = Mathf.Round(newPosition.y / gridy) * gridy;
			newPosition.z = Mathf.Round(newPosition.z / gridz) * gridz;
			transform.position = newPosition;
		}
	}
}
