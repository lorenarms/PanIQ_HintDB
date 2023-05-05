using System.ComponentModel.DataAnnotations;
using PanIQ_HintDB.Models;

namespace PanIQ_HintDB.ViewModels
{
	public class LogEntryFormViewModel
	{
		public IEnumerable<Room> Rooms { get; set; }

		public IEnumerable<Puzzle> Puzzles { get; set; }

		public IEnumerable<Hint> Hints { get; set; }

		public int Id { get; set; }
		public string? CustomText { get; set; }
		public string? Glitch { get; set; }
		public string? Bypass { get; set; }
		public DateTime DateAdded { get; set; }

		[Required]
		[Display(Name = "Hints")]
		public int HintId { get; set; }
		
		[Required]
		[Display(Name = "Puzzle")]
		public int PuzzleId { get; set; }
		
		[Required]
		[Display(Name = "Room")]
		public byte RoomId { get; set; }


		public string Title => Id != 0 ? "Edit Log Entry" : "New Log Entry";

		public LogEntryFormViewModel()
		{
			Id = 0;
			
		}

		public IEnumerable<Puzzle> SetPuzzles(byte id)
		{
			List<Puzzle> selectablePuzzles = null;
			foreach (var puzzle in Puzzles)
			{
				if (puzzle.Room.Id == id)
				{
					selectablePuzzles.Add(puzzle);
				}
			}
			return selectablePuzzles;
		}

		public LogEntryFormViewModel(LogEntry entry)
		{
			Id = entry.Id;
			CustomText = entry.CustomText;
			Glitch = entry.Glitch;
			Bypass = entry.Bypass;
			DateAdded = entry.DateAdded;
			HintId = entry.HintId;
		}


		public CurrentTime _ct = new CurrentTime(DateTime.Now);

		public class CurrentTime
		{
			public CurrentTime(DateTime now)
			{
				// TODO: modify this class to reflect new DB schema

				Date = now.ToString("yyyy-MM-dd");
				Time = now.ToString("HH:mm:ss");

				Today = $@"{now:D}";
				RightNow = $@"{now:h:mm tt}";
			}
			public string Date { get; set; }
			public string Time { get; set; }
			public string Today { get; set; }
			public string RightNow { get; set; }

		}
	}
}
