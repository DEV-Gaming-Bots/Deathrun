
global using System;
global using System.IO;
global using System.Linq;
global using System.Threading.Tasks;
global using Sandbox;
global using Sandbox.UI;
global using Sandbox.UI.Construct;
global using Deathrun.Player;


namespace Deathrun;


public partial class DRGame : GameManager
{
	public DRGame()
	{
	}

	public override void ClientJoined( IClient client )
	{
		base.ClientJoined( client );

		var pawn = new PlayerPawn(client);
		client.Pawn = pawn;
	}
}
