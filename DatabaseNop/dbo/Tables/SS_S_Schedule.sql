CREATE TABLE [dbo].[SS_S_Schedule] (
    [Id]                      INT      IDENTITY (1, 1) NOT NULL,
    [EntityType]              INT      NOT NULL,
    [EntityId]                INT      NOT NULL,
    [EntityFromDate]          DATETIME NULL,
    [EntityToDate]            DATETIME NULL,
    [SchedulePatternType]     INT      NOT NULL,
    [SchedulePatternFromTime] TIME (7) NULL,
    [SchedulePatternToTime]   TIME (7) NULL,
    [ExactDayValue]           INT      NULL,
    [EveryMonthFromDayValue]  INT      NULL,
    [EveryMonthToDayValue]    INT      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

