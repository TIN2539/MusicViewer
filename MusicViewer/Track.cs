using System.Collections.Generic;

namespace MusicViewer
{
	internal class Track : Item
	{
		public int AlbumId { get; set; }

		public int ArtistId { get; set; }

		public string Length { get; set; }

		public string DateReleased { get; set; }

		public List<int> GenresId { get; } = new List<int>();
	}
}