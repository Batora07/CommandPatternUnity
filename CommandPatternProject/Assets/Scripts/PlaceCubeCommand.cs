﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Concrete Strategy
/// </summary>
public class PlaceCubeCommand : ICommand
{
	private Vector3 position;
	private Color color;
	private Transform cube;

	public PlaceCubeCommand(Vector3 position, Color color, Transform cube)
	{
		this.position = position;
		this.color = color;
		this.cube = cube;
	}

	public void Execute()
	{
		CubePlacer.PlaceCube(position, color, cube);
	}

	public void Undo()
	{
		CubePlacer.RemoveCube(position, color);
	}

	public override string ToString()
	{
		return "PlaceCube\t" + position.x + ":" + position.y +":" + position.z + "\t" + color.r + ":" + color.g + ";" + color.b;
	}
}
