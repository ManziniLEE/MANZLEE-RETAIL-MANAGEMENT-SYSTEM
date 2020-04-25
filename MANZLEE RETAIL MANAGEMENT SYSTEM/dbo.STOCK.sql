CREATE TABLE [dbo].[STOCK] (
    [ITEM_Id]     UNIQUEIDENTIFIER          NOT NULL,
    [ITEM_NAME]   VARCHAR (50) NULL,
    [PRICE_NOVAT] MONEY        NULL,
    [TAX]         FLOAT (53)   NULL,
    [PRICE_VAT]   MONEY        NULL,
    [WEIGHT]      VARCHAR (50) NULL,
    [QUANTITY]    INT          NULL,
    PRIMARY KEY CLUSTERED ([ITEM_Id] ASC)
);

