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
	public GAMESTATE state;

	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if(state == GAMESTATE.NONE){
			if(Input.GetMouseButtonDown(0)){
				SceneManager.LoadScene("ship test");
				Debug.Log("MainScene loaded.");
				state = GAMESTATE.START;
			}
			if(state == GAMESTATE.GAMEOVER){
				state = GAMESTATE.QUIT;
			}
		}
		switch(state){
			case GAMESTATE.START:
			{
				state = GAMESTATE.PLAY;
			}
			break;
			case GAMESTATE.PLAY:
			{
				Debug.Log("Plaing.");
			}
			break;
			case GAMESTATE.CLEAR:
			{
				// clear
			}
			break;
			case GAMESTATE.GAMEOVER:
			{
				SceneManager.LoadScene("GameoverScene");
				Debug.Log("GameoverScene loaded.");
			}
			break;
			case GAMESTATE.RESTART:
			{
				// リスタート
			}
			break;
			case GAMESTATE.QUIT:
			{
				Debug.Log("quit.");
			}
			break;
		}
	}
}