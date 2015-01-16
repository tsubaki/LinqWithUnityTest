﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Error8 : MonoBehaviour 
{


	public struct Skill
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Element Element { get; set; }
	}

	List<Skill> GetSkillList ()
	{
		Skill[] skills = new Skill[]{
			new Skill(){ 
				Id = 32,
				Name = "hoge",
				Element = Element.Fire
			},
			new Skill(){ 
				Id = 12,
				Name = "moge",
				Element = Element.Thunder
			},			new Skill(){ 
				Id = 5,
				Name = "age",
				Element = Element.Wind
			},			new Skill(){ 
				Id = 34,
				Name = "doge",
				Element = Element.Fire
			},			new Skill(){ 
				Id = 68,
				Name = "SHIGERU",
				Element = Element.Wind
			},
		};

		return  new List<Skill>(skills);
	}
	
	public enum Element
	{
		Fire,Thunder,Wind,
	}

	void Start()
	{
		Debug.Log("Error8 ---");

		List<Skill> skillList = GetSkillList ();
		ILookup<Element, Skill> elementSkillLookup = skillList.ToLookup (skill => skill.Element);
		Debug.Log("1");

		IEqualityComparer<int> comparer = EqualityComparer<int>.Default;
		Dictionary<int, Skill> skillDictonary2 = skillList.ToDictionary (skill => skill.Id, comparer);
		Debug.Log("2");
	}
}
