// Copyright Conor McKnight
// Red Dead Redemption 2 Infinite money script

using RDR2;
using RDR2.UI;
using System;
using System.Windows.Forms;

namespace Money
{
	public class Main : Script
	{
		private int ammount;
		private Keys Interact;

		public Main()
		{
			this.KeyDown += new KeyEventHandler(this.OnKeyDown);
			this.Interact = ScriptSettings.Load("scripts/Money.ini").GetValue<Keys>("Options", "Interact", Keys.K);
			RDR2.UI.Screen.PrintSubtitle("Money Script Loaded\n~b~R.S~!b~");
		}

		private void OnKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != this.Interact)
				return;
			this.ammount = Convert.ToInt32(Game.GetUserInput(20));
			Game.Player.Money += this.ammount;
			RDR2.UI.Screen.PrintSubtitle("$" + (object)this.ammount + " Added!");
		}
	}
}
