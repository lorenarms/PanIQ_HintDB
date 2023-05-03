using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PanIQ_HintDB.Data.Migrations
{
    public partial class SeedHintsHaunted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql(@"

				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (1, 34, N'""SEE THE WOODEN KEY SUSPENDED ABOVE THE CABINET? CAN YOU REACH IT?""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (2, 34, N'""THE ROPES ARE TWISTED, BUT I THINK YOU CAN WORK IT FREE.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (3, 34, N'""IT LOOKS LIKE THE ROPES ARE ATTACHED TO SOMETHING THAT MOVES WITHIN THOSE SLOTS.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (4, 34, N'""CAN YOU GET THE KEY UNTANGLED BY SHIFTING THE ROPES AROUND IN THE SLOTS?""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (5, 34, N'""PERHAPS THE KEY IS NOT MEANT TO BE REMOVED – THE SECRET MAY LAY IN THE SLIDERS THEMSELVES.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (6, 34, N'""LOOK FOR A WAY TO USE THE KEY WITHOUT REMOVING IT – THE KEYHOLE MAY BE VERY CLOSE BY.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (7, 34, N'""IS THERE SOMETHING BENEATH THE SLIDERS? CHECK THE SLOTS CAREFULLY.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (8, 34, N'""THE KEYHOLE IS IN THE CENTER SLOT – MOVE THE SLIDERS TO UNCOVER IT.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (9, 34, N'""YOU NEEDN’T REMOVE THE KEY - JUST FREE IT ENOUGH TO REACH THE KEYHOLE.""')	


				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (3, 35, N'""THE PIECES CAN BE MOVED ABOUT TO SLIDE THE SYMBOLS TO THEIR HOMES.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (1, 35, N'""DO YOU SEE THE MAZE WITH THE CROSS AND THAT OTHER ODD SYMBOL, OVER IN THE CORNER? WE BROUGHT IT WITH US FROM DEUTSCHLAND.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (4, 35, N'""I WOULD BEGIN WITH THE CROSS…""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (5, 35, N'""MAKE SURE TO LEAVE ROOM FOR THE SECOND SYMBOL ON THE OTHER SIDE OF THE BARRIER.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (6, 35, N'""ONCE YOU GET THE CROSS TO ITS HOME, THE OTHER SYMBOL SHOULD BE EASY.""')	


				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (1, 36, N'""THAT SUN AND THE OLD GRANDFATHER CLOCK WERE MADE AS A SET, YOU KNOW… CAN’T SET THE ONE WITHOUT THE OTHER.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (2, 36, N'""THAT OLD CLOCK AND THE SUN ARE LIKE BROTHERS, BOUND TOGETHER IN WAYS THAT CAN’T BE SEEN.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (4, 36, N'""THE CLOCK WILL TELL YOU WHERE TO MOVE IT. YOU JUST NEED TO REMEMBER HOW.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (5, 36, N'""""I BELIEVE IT MOVES TO THE RIGHT… UNTIL IT DOESN’T.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (6, 36, N'""THE OLD CLOCK IS VERY PARTICULAR ABOUT HOW IT’S SET. YOU HAVE TO MOVE THE SUN DIAL TO THE POSITION THE CLOCK WANTS, AND REMEMBER WHICH DIRECTION IT WANTS YOU TO GO.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (7, 36, N'""IF YOU MOVE IN THE WRONG DIRECTION, THE CLOCK WILL LET YOU KNOW… YOU’LL HAVE TO TRY AGAIN AND AGAIN UNTIL YOU LEARN THE DIRECTIONS IT WANTS.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (8, 36, N'PARTIAL SOLUTION (PICTURE)')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (9, 36, N'FULL SOLUTION (PICTURE)')	


				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (1, 37, N'""I BELIEVE THERE ARE OTHER PIECES LIKE THESE OVER ON THE TABLE.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (2, 37, N'""THOSE GHASTLY PIECES DO SEEM TO BE A PART OF THAT PUZZLE. DO THEY FIT?""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (3, 37, N'""IF THEY AREN’T FITTING, THINGS WILL NEED TO BE REARRANGED SOMEHOW.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (4, 37, N'""HAVE YOU TRIED ROTATING THE PIECES? I’M SURE THEY WILL ALL FIT.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (5, 37, N'""THERE ARE MANY WAYS THE PIECES CAN TURN, BUT ONLY ONE THAT IS CORRECT.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (6, 37, N'PARTIAL SOLUTION 3PCS IN')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (7, 37, N'PARTIAL SOLUTION 4PCS IN')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (8, 37, N'PARTIAL SOLUTION 6PCS IN')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (9, 37, N'SOLUTION ALL PCS IN')	


				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (1, 38, N'""THE MIRROR IS SO CLOUDY… HAS IT REALLY BEEN THAT LONG?""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (2, 38, N'""THEY SAY SOME PRESENCES CAN ONLY BE SEEN IN A MIRROR... HAVE A LOOK.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (3, 38, N'""LOOK CLOSELY; IT CONTAINS MORE THAN JUST YOUR REFLECTION.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (4, 38, N'""THE SYMBOLS WITHIN SEEM TO BE BACKWARDS.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (5, 38, N'""HOW CAN YOU REVERSE THEM AND SEE THEIR “MIRROR IMAGE”?""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (6, 38, N'""USE THE HAND MIRROR TO LOOK AT THE SYMBOLS – I THINK IT WILL BECOME CLEAR FOR YOU THEN.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (7, 38, N'TEXT OF THE POEM')	


				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (1, 39, N'""THE MIRROR CALLS OUT SOME OF THE INSTRUMENTS""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (2, 39, N'""“LISTEN TO THE SOUNDS OF RAIN, AND HIT THE TAM-TAM TO ENTERTAIN” - WHAT DOES IT MEAN?""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (3, 39, N'PICTURE OF SOUNDS OF RAIN')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (4, 39, N'PICTURE OF TAM-TAM')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (5, 39, N'""“PLAY THE STRINGS OF MIND” - THERE IS ONLY ONE STRINGED INSTRUMENT HERE…""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (6, 39, N'PICTURE OF STRINGS OF MIND')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (8, 39, N'""PUT THE INSTRUMENTS IN ORDER TO UNDERSTAND THE MIRROR’S MESSAGE.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (9, 39, N'""LOOK INTO THE MIRROR TO READ THE LYRICS, AND PLAY THE INSTRUMENTS AS THE SONG DIRECTS, THEN READ THE LETTER ON EACH INSTRUMENT IN ORDER TO GET THE FOUR-LETTER COLOR.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (10, 39, N'""THE LETTERS ARE B, L, U, AND E.""')	


				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (1, 40, N'""HOW DID MY OLD DIARY GET THERE? I USUALLY KEEP IT IN A DRAWER.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (2, 40, N'PICTURE: ""MAKE SURE TO CLOSE THE DRAWER AND KEEP MY DIARY SAFE FROM INTRUDERS.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (3, 40, N'""BE A DARLING, AND PUT THE DIARY AWAY FOR ME, PLEASE.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (4, 40, N'""DO BE SURE TO CLOSE THE DRAWER COMPLETELY TO KEEP MY DIARY SAFE.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (5, 40, N'""WOULD YOU BE A DEAR AND CHECK ON MY DIARY IN THE DRAWER?""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (6, 40, N'""IS THE DIARY WELL-HIDDEN NOW? THAT DRAWER IS MORE THAN IT SEEMS…""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (7, 40, N'PICTURE: ""DID YOU CHECK THAT THE DRAWER WAS CLOSED AND MY DIARY IS SAFELY HIDDEN?""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (8, 40, N'""DID YOU FIND THE SPECIAL CROSS IN THE DRAWER?""')	


				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (1, 41, N'""LISTEN TO THE RADIO… WHAT IS IT SAYING?""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (2, 41, N'""SOUNDS LIKE THE FREQUENCY NEEDS TO BE TUNED IN A BIT MORE.""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (3, 41, N'""SOMEHOW THE KNOB SEEMS TO CHANGE THE SPEED…""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (4, 41, N'""I BELIEVE IT WAS PLAYING BACKWARDS... PERHAPS THE KNOB CAN SWITCH IT AROUND.""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (5, 41, N'""WAS THAT MY VIRGINIA? CHANGE THE SPEED SO YOU CAN UNDERSTAND HER.""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (6, 41, N'""DID YOU HEAR WHAT HER FAVORITE COLOR WAS?""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (7, 41, N'""SHE DID SO LOVE YELLOW…""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (8, 41, N'AUDIO RECORDING OF SOLUTION (DISTORTED)')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (9, 41, N'AUDIO RECORDING OF SOLUTION (ORIGINAL)')


				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (1, 42, N'""I SEE YOU’VE FOUND THE CROSS. IT USED TO HANG ON OUR CABINET.""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (2, 42, N'""I THINK THE NAILS IT HUNG ON HAVE GONE MISSING… BUT NO MATTER. YOU CAN SEE WHERE IT WAS.""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (3, 42, N'""THE MESSAGE IS CLEAR, IF YOU LET THE HOLES GUIDE YOU.""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (4, 42, N'""COLORS WERE SO IMPORTANT TO US. LOOK FOR THE COLOR TO THE RIGHT.""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (5, 42, N'PICTURE OF LOCATION')


				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (1, 43, N'""AREN’T THE CANDLES BEAUTIFUL? SO MANY COLORS…""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (2, 43, N'""AT NANA’S BIRTHDAY, WE EACH HAD A CANDLE OF OUR FAVORITE COLOR.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (3, 43, N'""BLOW THEM OUT BEFORE THEY BURN DOWN TOO MUCH…""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (4, 43, N'""YOU HAVE TO BE QUICK, BEFORE THE COLORS CHANGE.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (5, 43, N'""YOU NEED TO KNOW WHICH CANDLES TO BLOW OUT… YOU MUST KNOW THE THREE COLORS""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (6, 43, N'""YOU MUST LEARN THE COLORS BY UNRAVELING THE MYSTERIES OF THE OTHER OBJECTS IN THIS ROOM""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (7, 43, N'""THE COLORS WERE FAVORITES OF THE FAMILY MEMBERS. THE CROSS TELLS ONE, THE RADIO SPEAKS ANOTHER, WHILE THE INSTRUMENTS SPELL THE THIRD.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (8, 43, N'""VIRGINIA’S FAVORITE COLOR WAS YELLOW… THE CROSS REVEALS MY LOVE OF PINK, AND KATARINA’S INSTRUMENTS SING OF BLUE.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (9, 43, N'""YOU MUST BLOW OUT THE CANDLES OF PINK, YELLOW, AND BLUE.""')	


				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (1, 44, N'""AH, THE CHILDREN DO SO LOVE THEIR THREAD BOARD…""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (2, 44, N'""REMEMBER, THERE ARE TWO SIDES TO EVERY STORY... AND TO THE BATHROOM DOOR AS WELL.""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (3, 44, N'""THE THREADBOARD IS A GUIDE TO THE LETTERS ON THE BATHROOM DOOR.""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (4, 44, N'""JUST FOLLOW THE STRING TO FIND EVERYONE’S NAME.""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (5, 44, N'""ONLY THE PORTRAITS OF FAMILY MEMBERS WILL DO, I’M AFRAID.""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (6, 44, N'""FIND THE START SIGNS… ONE ON THE THREADBOARD, AND THE OTHER SOMEWHERE IN THE BATHROOM.""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (7, 44, N'""LOOK AT THE PATH OF THE STRING, AND TRACE IT OUT ON THE LETTER BOARDS.""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (8, 44, N'""THE FIRST NAME START WITH A V…""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (9, 44, N'""THE FIRST NAME YOU’RE LOOKING FOR IS VINCENT… KEEP FOLLOWING THE STRING TO FIND THE OTHERS’ NAMES.""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (10, 44, N'""THEIR NAMES BEGIN WITH A V… AN L, AND A G…""')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (12, 44, N'PICTURE OF DOOR')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (13, 44, N'PICTURE OF BOARDS')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (14, 44, N'PICTURE OF BOARDS')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (15, 44, N'TEXT: GREGORY, VINCENT, LUCY')
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (16, 44, N'VISUAL EXPLANATION')


				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (1, 45, N'""OH, I REMEMBER THAT DAY – IT WAS SUCH A HAPPY MOMENT FOR ALL OF US.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (2, 45, N'""PLEASE, FIND THE RIGHT PLACE FOR THIS PORTRAIT. IT SHOULD BE ENSHRINED FOREVER…""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (3, 45, N'""OUR FAMILY HAS OWNED THAT OLD BOOKCASE FOR CENTURIES. IT HELD OUR MOST BELOVED BOOKS.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (4, 45, N'""PUT THE PORTRAIT ON A HIGH SPOT, OUT OF THE WAY, WHERE WE CAN REST…""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (5, 45, N'""WE WERE ALL AVID READERS; PERHAPS THE BOOKCASE IS WHERE WE COULD REST TOGETHER.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (6, 45, N'""THERE IS A PERFECT SPOT FOR US ON THE TOP SHELF OF THE BOOKCASE, RIGHT IN THE CENTER.""')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (7, 45, N'PICTURE OF BOOKCASE')	
				INSERT INTO [dbo].[Hint] ([Order], [PuzzleId], [Text]) VALUES (8, 45, N'PICTURE OF PORTRAIT SLOT')	


			");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
