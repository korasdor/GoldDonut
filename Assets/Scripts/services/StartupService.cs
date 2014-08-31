using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class StartupService {

	MonoBehaviour host;

	RemoteService remoteService;

	IController controller;

	GameModel gameModel;
	GameBehav gameBehav;

	public StartupService(MonoBehaviour host){
		this.host = host;
	}

	public void Init() {

		InitAudios();
		InitModels();
		InitBehavs();

		remoteService = new RemoteService();

		SetController(ApplicationData.GAME_STATE);
	}

	void SetController (string type)
	{
		switch (type) {
			case ApplicationData.GAME_STATE :
				controller = new GameController();
				break;
		}

		controller.SetData(gameModel, gameBehav, remoteService);
		controller.Init(SetController);
	}

	void InitAudios ()
	{

	}

	void InitModels ()
	{
		gameModel = new GameModel();
	}

	void InitBehavs ()
	{
		gameBehav = host.gameObject.AddComponent<GameBehav>();
	}
}