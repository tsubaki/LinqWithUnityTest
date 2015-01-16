using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Error3 : MonoBehaviour 
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
		Debug.Log("Error3 ---");
		List<RecordStruct> recordClassList = GetRecordStructList ();
		int max = recordClassList.Max (record => record.Score);
		int min = recordClassList.Min (record => record.Score);
		int sum = recordClassList.Sum (record => record.Score);

		Debug.Log("max:" + max); 
		Debug.Log("min:" + min); 
		Debug.Log("sum:" + sum); 
	}
}
