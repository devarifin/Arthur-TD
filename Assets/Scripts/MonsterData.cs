using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
	public class MonsterLevel{
		public int cost;
		public GameObject  visualization;
	}

public class MonsterData : MonoBehaviour {

	public List<MonsterLevel> levels;
	private MonsterLevel currentLevel;

	public MonsterLevel CurrentLevel{
		get{
			return currentLevel;
		}
		set{
			currentLevel = value;
			int currentLevelindex = levels.IndexOf(currentLevel);
			GameObject levelVisualization = levels[currentLevelindex].visualization;
			for(int i=0;i<levels.Count;i++){
				if(levelVisualization != null){
					if(i == currentLevelindex){
						levels[i].visualization.SetActive(true);
					}
					else{
						levels[i].visualization.SetActive(false);
					}
				}
			}
		}
	}

	void OnEnable(){
		CurrentLevel = levels[0];
	}

	public MonsterLevel GetNextLevel(){
		int currentLevelindex = levels.IndexOf (currentLevel);
		int maxLevelIndex = levels.Count - 1;
		if(currentLevelindex < maxLevelIndex){
			return levels[currentLevelindex+1];
		}
		else{
			return null;
		}
	}

	public void IncreaseLevel(){
		int currentLevelindex = levels.IndexOf(currentLevel);
		if(currentLevelindex < levels.Count - 1){
			CurrentLevel = levels[currentLevelindex + 1];
		}
	}
}
