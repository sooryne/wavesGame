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
	private int restartCount;

	void Start () {
		state = GAMESTATE.START;
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
				// clearシーン
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
				if(Input.GetKeyDown(KeyCode.Space)){
					Debug.Log("ロード");
					SceneManager.LoadScene("ship test");
					state = GAMESTATE.PLAY;
				}
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
				Debug.Log("Gameover");
				// Gameoverシーンを読み込む
				SceneManager.LoadScene("GameoverScene");
				if(Input.GetKeyDown(KeyCode.Space)){
					state = GAMESTATE.RESTART;
					restartCount++;
				}
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