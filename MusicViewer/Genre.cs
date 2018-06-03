using System.Collections.Generic;

namespace MusicViewer
{
	internal class Genre : Item
	{
		public ICollection<Genre> Genres { get; } = new List<Genre>();
	}
}