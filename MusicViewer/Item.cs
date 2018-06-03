namespace MusicViewer
{
	internal abstract class Item
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}