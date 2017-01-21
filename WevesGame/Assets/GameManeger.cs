using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour {

// ステートの定義
	public enum GameState{
		None = -1,
		Start,
		Play,
		Clear,
		Gameover,
	}
	GameState state = GameState.None;

	void Start () {
		state = GameState.Start;
	}

	// Update is called once per frame
	void Update () {
		// ステート遷移+実行フェイズ
		switch(state){
			case GameState.Start:
			break;
			case GameState.Play:
			break;
			case GameState.Clear:
			break;
			case GameState.Gameover:
			break;
			}
		// 実行フェイズ
		switch(state){
			case GameState.Start:
			break;
			case GameState.Play:
			break;
			case GameState.Clear:
			break;
			case GameState.Gameover:
			break;
		}
	}
}