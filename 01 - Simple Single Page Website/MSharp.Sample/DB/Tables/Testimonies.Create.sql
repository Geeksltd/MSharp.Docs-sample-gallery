-- Testimonies Table ========================
CREATE TABLE Testimonies (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Image_FileName nvarchar(1500)  NULL,
    Name nvarchar(200)  NOT NULL,
    [Position] nvarchar(200)  NOT NULL,
    Content nvarchar(2000)  NOT NULL,
    DisplayOrder int  NULL
);

