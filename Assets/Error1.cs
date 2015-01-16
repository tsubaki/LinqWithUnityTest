using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Error1 : MonoBehaviour 
{
	List<RecordStruct> GetRecordStructList ()
	{
		List<RecordStruct> list = new List<RecordStruct>();

		list.AddRange(new RecordStruct[]{
			new RecordStruct(){ Score = 1},
			new RecordStruct(){ Score = 3},
			new RecordStruct(){ Score = 5},
			new RecordStruct(){ Score = 7},
			new RecordStruct(){ Score = 9},
		});

		return list;
	}

	public struct RecordStruct
	{
		public int Score { get; set; }
	}

	void Start()
	{
		Debug.Log("Error1 ---");
		List<RecordStruct> recordStructList = GetRecordStructList ();
		double average = recordStructList.Average (record => record.Score);

		Debug.Log( average); 
	}
}
