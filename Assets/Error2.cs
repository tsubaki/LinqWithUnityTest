using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Error2 : MonoBehaviour 
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
		Debug.Log("Error2 ---");
		List<RecordClass> recordClassList = GetRecordClassList ();
		double average = recordClassList.Average (record => record.Score);

		Debug.Log( average); 
	}
}
