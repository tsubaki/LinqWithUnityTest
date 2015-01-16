using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public class Error11 : MonoBehaviour 
{
	List<Vector2> vecList = new List<Vector2> {
		new Vector2 (3, 3),
		new Vector2 (1, 1),
		new Vector2 (0, 0),
		new Vector2 (2, 2)
	};
	


	void Start()
	{
		Debug.Log("Error11 ---");

		IOrderedEnumerable<Vector2> orderedVecList = vecList.OrderBy(v => v.magnitude); // ここではエラーにならない
		
		foreach (Vector2 vec in orderedVecList) { // ここでエラーになる
			Debug.Log (vec);
		}
	}
}
