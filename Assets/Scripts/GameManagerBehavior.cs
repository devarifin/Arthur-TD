using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerBehavior : MonoBehaviour {
	public Text goldLabel;
	private int gold;

	public Text healthLabel;
	public GameObject[] healthIndicator;
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
	
	private int health;
	public int Health{
		get{
			return health;
		}
		set{
			if(value < health){
				Camera.main.GetComponent<CameraShake>().Shake();
			}
			health = value;
			healthLabel.text = "HEALTH: " + health;

			if(health <= 0 && !gameOver){
				gameOver = true;
				GameObject gameOverText = GameObject.FindGameObjectWithTag("GameOver");
				gameOverText.GetComponent<Animator>().SetBool("gameOver", true);
			}

			for(int i = 0;i < healthIndicator.Length;i++){
				if(i < Health){
					healthIndicator[i].SetActive(true);
				}
				else{
					healthIndicator[i].SetActive(false);
				}
			}
		}
	}
}
