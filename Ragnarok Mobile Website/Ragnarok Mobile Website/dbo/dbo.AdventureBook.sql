CREATE TABLE [dbo].[AdventureBook] (
    [CharacterId]    INT IDENTITY (1, 1) NOT NULL,
    [MaximumHp]      INT NOT NULL,
    [PhysicalAttack] INT NOT NULL,
    [MagicAttack]    INT NOT NULL,
    [GachaDeposit]   INT NOT NULL,
    CONSTRAINT [PK_AdventureBook] PRIMARY KEY CLUSTERED ([CharacterId] ASC)
);

