﻿using UnityEngine;
using System.Collections;
using Assets.Scripts.UI;
using Assets.Scripts.Managers;

public class UILevelSwitch : MonoBehaviour {

	public string[] levels = {"Loading",
		"MenuTest",
		"Testing",
		"BoosterPackSelection",
		"Credits",
		"Level1",
		"Level2",
		"Level3",
		"Level4",
		"Level5",
		"BoosterPackSelectionMultiplayer",
		"MultiplayerBattle"};

	public void LevelSwitch(int level) {
		LoadingScreen.LevelToLoad = levels[level];
		Debug.Log(levels[level]);
		LoadingScreen.instance.LoadLevel(levels[level]);
	}

	public void LevelSwitchForPackSelection(int level) {
		GameManager.CardSelect = true;
		Application.LoadLevel(level);
	}

	public void ReloadLevel() {
		LevelSwitch(Application.loadedLevel);
	}

	public void SetLoadingLevel(string _level) {
		LoadingScreen.LevelToLoad = _level;
	}
}
