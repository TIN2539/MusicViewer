using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace MusicViewer
{
	internal partial class MainForm : Form
	{
		private IEnumerable<Album> albums;
		private IEnumerable<Artist> artists;
		private DateTime fromDate;
		private IEnumerable<Genre> genres;
		private DateTime toDate;
		private IEnumerable<Track> tracks;

		public MainForm()
		{
			InitializeComponent();
		}

		private void ClearAllLabelText()
		{
			albumTextBox.Clear();
			releasedTextBox.Clear();
			lengthTextBox.Clear();
			genresTextBox.Clear();
		}

		private void ComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			listBox.Items.Clear();
			ClearAllLabelText();
			fromDate = DateTime.MaxValue;
			toDate = DateTime.MinValue;
			foreach (var track in tracks)
			{
				foreach (var artist in artists)
				{
					if (comboBox.Text == artist.Name && track.ArtistId == artist.Id)
					{
						listBox.Items.Add(track);
						if (DateTime.Parse(track.DateReleased) < fromDate)
						{
							fromDate = DateTime.Parse(track.DateReleased);
						}
						if (DateTime.Parse(track.DateReleased) > toDate)
						{
							toDate = DateTime.Parse(track.DateReleased);
						}
					}
				}
			}
			listBox.Sorted = true;
			fromDateTimePicker.Value = fromDate;
			toDateTimePicker.Value = toDate;
			fromDateTimePicker.Enabled = true;
			toDateTimePicker.Enabled = true;
		}

		private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			if (fromDateTimePicker.Value < fromDate || fromDateTimePicker.Value > toDateTimePicker.Value)
			{
				fromDateTimePicker.Value = fromDate;
			}
			UpdateListboxTracks();
		}

		private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ClearAllLabelText();
			foreach (var track in tracks)
			{
				if (listBox.SelectedItem != null && listBox.SelectedItem.ToString() == track.Name)
				{
					foreach (var artist in artists)
					{
						if (track.ArtistId == artist.Id)
						{
							foreach (var album in albums)
							{
								if (track.AlbumId == album.Id)
								{
									albumTextBox.Text = album.Name;
									break;
								}
							}
							releasedTextBox.Text = DateTime.Parse(track.DateReleased).ToString("d MMMM yyyy");
							lengthTextBox.Text = track.Length.ToString();
							List<string> sortedGenres = new List<string>();
							foreach (var genre in genres)
							{
								foreach (var tracIdGenre in track.GenresId)
									if (genre.Id == tracIdGenre)
									{
										sortedGenres.Add(genre.Name);
									}
							}
							sortedGenres.Sort();
							foreach (var genre in sortedGenres)
							{
								genresTextBox.Text += $"{genre}, ";
							}
							genresTextBox.Text = genresTextBox.Text.Remove(genresTextBox.Text.Length - 2, 2);
							break;
						}
					}
					break;
				}
			}
		}

		private void LoadButton_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				comboBox.Items.Clear();
				comboBox.Text = "";
				ClearAllLabelText();
				listBox.Items.Clear();
				fromDateTimePicker.Enabled = false;
				toDateTimePicker.Enabled = false;
				ReadXml(openFileDialog.FileName);
				foreach (var artist in artists)
				{
					comboBox.Items.Add(artist);
				}
				comboBox.Sorted = true;
			}
		}

		private void ReadXml(string fileName)
		{
			var loadAlbums = new List<Album>();
			var loadArtists = new List<Artist>();
			var loadGenres = new List<Genre>();
			var loadTracks = new List<Track>();

			using (XmlReader reader = XmlReader.Create(fileName))
			{
				while (reader.Read())
				{
					if (reader.IsStartElement())
					{
						if (reader.Name == "album")
						{
							var album = new Album
							{
								Id = int.Parse(reader.GetAttribute("id")),
								Name = reader.GetAttribute("name")
							};

							loadAlbums.Add(album);
						}
						else if (reader.Name == "artist")
						{
							var artist = new Artist
							{
								Id = int.Parse(reader.GetAttribute("id")),
								Name = reader.GetAttribute("name")
							};

							loadArtists.Add(artist);
						}
						else if (reader.Name == "genre")
						{
							var genre = new Genre
							{
								Id = int.Parse(reader.GetAttribute("id")),
								Name = reader.GetAttribute("name")
							};

							loadGenres.Add(genre);
						}
						else if (reader.Name == "track")
						{
							var track = new Track
							{
								AlbumId = int.Parse(reader.GetAttribute("album-id")),
								ArtistId = int.Parse(reader.GetAttribute("artist-id")),
								Length = DateTime.Parse(reader.GetAttribute("length")).ToShortTimeString(),
								Name = reader.GetAttribute("name"),
								Id = int.Parse(reader.GetAttribute("number")),
								DateReleased = DateTime.Parse(reader.GetAttribute("released")).Date.ToLongDateString(),
							};

							reader.Read();
							reader.Read();
							reader.Read();

							while (reader.IsStartElement("genre"))
							{
								track.GenresId.Add(int.Parse(reader.GetAttribute("genre-id")));
								reader.Read();
							}

							loadTracks.Add(track);
						}
					}
				}
				albums = loadAlbums;
				artists = loadArtists;
				genres = loadGenres;
				tracks = loadTracks;
			}
		}

		private void ToDateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			if (toDateTimePicker.Value > toDate || toDateTimePicker.Value < fromDateTimePicker.Value)
			{
				toDateTimePicker.Value = toDate;
			}
			UpdateListboxTracks();
		}

		private void UpdateListboxTracks()
		{
			listBox.Items.Clear();
			foreach (var track in tracks)
			{
				foreach (var artist in artists)
				{
					if (comboBox.Text == artist.Name && track.ArtistId == artist.Id && DateTime.Parse(track.DateReleased) >= fromDateTimePicker.Value &&
						DateTime.Parse(track.DateReleased) <= toDateTimePicker.Value)
					{
						listBox.Items.Add(track);
					}
				}
			}
		}
	}
}