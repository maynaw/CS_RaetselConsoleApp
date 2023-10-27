using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetselprogramm
{
    class MoeglicheAntwort
	{
		private string Text;

		public string text
		{
			get { return Text; }
			set { Text = value; }
		}

		private string Id;

		public string id
		{
			get { return Id; }
			set { Id = value; }
		}

		private bool Richtig;

		public bool richtig
		{
			get { return Richtig; }
			set { Richtig = value; }
		}

		public MoeglicheAntwort(string id, string text, bool richtig)
		{
			this.Id = id;
			this.Text = text;
			this.Richtig = richtig;
		}

	}
}

