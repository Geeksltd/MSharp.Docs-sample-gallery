-- Clients Table ========================
CREATE TABLE Clients (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(200)  NOT NULL,
    Image_FileName nvarchar(1500)  NULL
);

