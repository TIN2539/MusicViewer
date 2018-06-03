using System.Collections.Generic;

namespace MusicViewer
{
	internal class Album : Item
	{
		public ICollection<Album> Albums { get; } = new List<Album>();
	}
}