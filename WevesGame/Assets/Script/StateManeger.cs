using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateManeger : MonoBehaviour {

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
	public GAMESTATE state = GAMESTATE.NONE;

	void Start () {
	}

	// Update is called once per frame
	void Update () {
		
		// ステート遷移＋初期化フェイズ
		switch(state){
			case GAMESTATE.START:
			{

			}
			break;
			case GAMESTATE.PLAY:
			{
				// play
			}
			break;
			case GAMESTATE.CLEAR:
			{
				// clear
			}
			break;
			case GAMESTATE.GAMEOVER:
			{
				// Gameoverシーン
			}
			break;
			case GAMESTATE.RESTART:
			{
				// リスタート
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
				Debug.Log("start");
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