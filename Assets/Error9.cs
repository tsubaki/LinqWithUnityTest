using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Error9 : MonoBehaviour 
{


	public class Skill // こちらは構造体ではなくて、クラスなことに注意
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Element Element { get; set; }
	}
	
	public enum Element
	{
		Fire,Thunder,Wind,
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


	void Start()
	{
		Debug.Log("Error9 ---");

		List<Skill> skillList = GetSkillList ();
		IEqualityComparer<Element> comparer = EqualityComparer<Element>.Default;
		ILookup<Element, Skill> elementSkillLookup = skillList.ToLookup (skill => skill.Element, comparer);
		Debug.Log("1");

	}
}
