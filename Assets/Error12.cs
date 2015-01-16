using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public class Error12 : MonoBehaviour 
{

	public class PlayData
	{
		public DateTime At { get; set; }
		public int Score { get; set; }
		public string Name { get; set; }
	}

	void Start()
	{
		Debug.Log("Error12 ---");

		List<PlayData> playDataList = new List<PlayData> {
			new PlayData { Score = 50, Name = "B", At = new DateTime(2014, 1, 1, 0, 15, 0) },
			new PlayData { Score = 40, Name = "A", At = new DateTime(2014, 1, 1, 0, 20, 0) },
			new PlayData { Score = 50, Name = "A", At = new DateTime(2014, 1, 1, 0, 25, 0) },
			new PlayData { Score = 50, Name = "B", At = new DateTime(2014, 1, 1, 0, 30, 0) },
			new PlayData { Score = 20, Name = "C", At = new DateTime(2014, 1, 1, 0, 35, 0) },
			new PlayData { Score = 40, Name = "C", At = new DateTime(2014, 1, 1, 0, 40, 0) },
		};

		foreach (var playData in playDataList.OrderBy (it => it.Score).ThenBy (it => it.At)) {
			Debug.Log (playData.Name + " " + playData.Score);
		}
		Debug.Log("(1)");
	
		foreach (var playData in playDataList.OrderBy (it => it.Score).ThenByDescending (it => it.At)) {
			Debug.Log (playData.Name + " " + playData.Score);
		}
		Debug.Log("(2)");
	}
}
