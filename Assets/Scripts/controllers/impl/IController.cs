using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using System;

public interface IController {

	void SetData(GameModel gameModel, GameBehav gameBehav, RemoteService remoteService);
	void Init(Action<string> callback);
	void Update();
	void Dispose();
}
