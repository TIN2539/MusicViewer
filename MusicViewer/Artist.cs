using System.Collections.Generic;

namespace MusicViewer
{
	internal class Artist : Item
	{
		public ICollection<Artist> Artists { get; } = new List<Artist>();
	}
}