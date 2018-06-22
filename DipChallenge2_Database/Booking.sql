CREATE TABLE [dbo].[Booking]
(
	[Payment] MONEY NOT NULL PRIMARY KEY, 
    [DateBooked] DATE NULL,

	[ClientID] INT NOT NULL,
	FOREIGN KEY ([ClientID]) REFERENCES [Client]([ClientID]),

	[EventID] INT NOT NULL,
	FOREIGN KEY ([EventID]) REFERENCES [Event]([EventID]),

	CONSTRAINT [UniqueBooking] UNIQUE([ClientID],[EventID],[DateBooked])
)
