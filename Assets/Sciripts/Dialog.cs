using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExcelAsset]
public class Dialog : ScriptableObject
{
	public List<DialogDBEntity> Enter; // Replace 'EntityType' to an actual type that is serializable.
}
