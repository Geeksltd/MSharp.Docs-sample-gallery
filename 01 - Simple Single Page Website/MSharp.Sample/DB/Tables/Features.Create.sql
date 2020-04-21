-- Features Table ========================
CREATE TABLE Features (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Title nvarchar(200)  NOT NULL,
    Description nvarchar(200)  NOT NULL
);

