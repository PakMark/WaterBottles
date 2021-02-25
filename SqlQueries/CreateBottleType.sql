CREATE TABLE BottleType
(
	[BottleTypeId][INT] IDENTITY(1, 1) NOT NULL,
	[Volume][INT] NOT NULL,

	CONSTRAINT PK_BottleType PRIMARY KEY (BottleTypeId)
)
