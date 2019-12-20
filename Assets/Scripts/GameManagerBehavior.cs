using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerBehavior : MonoBehaviour {
	public Text goldLabel;
	private int gold;

	void Start(){
		Gold = 500;
	}

	public int Gold{
		get{
			return gold;
		}
		set{
			gold = value;
			goldLabel.GetComponent<Text>().text = "GOLD: " + gold;
		}
	}
	
}
