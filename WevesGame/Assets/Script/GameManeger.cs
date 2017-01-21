using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour {

// ステートの定義
	public enum GAMESTATE{
		NONE = -1,
		START,
		PLAY,
		CLEAR,
		GAMEOVER,
		RESTART,
		QUIT,
	}
	GAMESTATE state = GAMESTATE.NONE;

	void Start () {
		state = GAMESTATE.START;
	}

	// Update is called once per frame
	void Update () {
		// ステート遷移＋初期化フェイズ
		switch(state){
			case GAMESTATE.START:
			{
				// 左クリックで開始
				if(Input.GetMouseButton(0)){
					state = GAMESTATE.PLAY;
				}
			}
			break;
			case GAMESTATE.PLAY:
			{
				// play
				// クリックで挙動を変える
				if(Input.GetMouseButton(0)){
					state = GAMESTATE.CLEAR;
				}else if(Input.GetMouseButton(1)){
					state = GAMESTATE.GAMEOVER;
				}
			}
			break;
			case GAMESTATE.CLEAR:
			{
				// clearシーン
				if(Input.GetMouseButton(0)){
					state = GAMESTATE.RESTART;
				}else if(Input.GetMouseButton(1)){
					state = GAMESTATE.QUIT;
				}
			}
			break;
			case GAMESTATE.GAMEOVER:
			{
				// Gameoverシーン
				if(Input.GetMouseButton(0)){
					state = GAMESTATE.RESTART;
				}else if(Input.GetMouseButton(1)){
					state = GAMESTATE.QUIT;
				}
			}
			break;
			case GAMESTATE.RESTART:
			{
				// リスタート
				if(Input.GetMouseButton(0)){
					state = GAMESTATE.PLAY;
				}
			}
			break;
			case GAMESTATE.QUIT:
			{
				// ゲーム終了
			}
			break;
		}
		// 実行フェイズ
		switch(state){
			case GAMESTATE.START:
			{
				// スタート画面
				Debug.Log("Start");
			}
			break;
			case GAMESTATE.PLAY:
			{
				// play
				Debug.Log("Play");
			}
			break;
			case GAMESTATE.CLEAR:
			{
				// clearシーンの表示
				Debug.Log("Clear");
			}
			break;
			case GAMESTATE.GAMEOVER:
			{
				// Gameoverシーン
				Debug.Log("Gameover");
			}
			break;
			case GAMESTATE.RESTART:
			{
				Debug.Log("Restart");
			}
			break;
			case GAMESTATE.QUIT:
			{
				Debug.Log("Quit");
			}
			break;
		}
	}
}