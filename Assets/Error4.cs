using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Error4 : MonoBehaviour 
{
	List<RecordClass> GetRecordClassList ()
	{
		List<RecordClass> list = new List<RecordClass>();
		
		list.AddRange(new RecordClass[]{
			new RecordClass(){ Score = 1},
			new RecordClass(){ Score = 3},
			new RecordClass(){ Score = 5},
			new RecordClass(){ Score = 7},
			new RecordClass(){ Score = 9},
		});
		
		return list;
	}
	
	public class RecordClass
	{
		public int Score { get; set; }
	}

	void Start()
	{
		Debug.Log("Error4 ---");

		List<RecordClass> scoreClassList = GetRecordClassList ();
		int max = scoreClassList.Select(score => score.Score).Max ();
		int min = scoreClassList.Select(score => score.Score).Min ();
		int sum = scoreClassList.Select(score => score.Score).Sum ();

		Debug.Log("max:" + max); 
		Debug.Log("min:" + min); 
		Debug.Log("sum:" + sum); 
	}
}
