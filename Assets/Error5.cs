using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Error5 : MonoBehaviour 
{
	List<RecordStruct> GetRecordStructList ()
	{
		List<RecordStruct> list = new List<RecordStruct>();
		
		list.AddRange(new RecordStruct[]{
			new RecordStruct(){ Score = 1},
			new RecordStruct(){ Score = 3},
			new RecordStruct(){ Score = 5},
			new RecordStruct(){ Score = 7},
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
		Debug.Log("Error5 ---");

		List<RecordStruct> recordList = GetRecordStructList();
		
		RecordStruct firstOrDefaultResult  = recordList.FirstOrDefault ();
		Debug.Log("first" + firstOrDefaultResult.Score);

		RecordStruct lastResult            = recordList.Last ();
		Debug.Log("last" + lastResult.Score);

		RecordStruct lastOrDefaultResult   = recordList.LastOrDefault ();
		Debug.Log("last default" + lastOrDefaultResult.Score);

		Debug.Log("single not work");
		//RecordStruct singleResult          = recordList.Single ();
		//Debug.Log("single" + singleResult.Score);

		//RecordStruct SingleOrDefaultResult = recordList. SingleOrDefault ();
		//Debug.Log("single default" + SingleOrDefaultResult.Score);
	}
}
