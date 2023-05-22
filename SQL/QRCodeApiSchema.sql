CREATE DATABASE QRCodeApiDatabase;
GO

USE QRCodeApiDatabase;
GO 

CREATE SCHEMA QRCodeApiSchema;
GO

CREATE TABLE QRCodeApiSchema.QRCodes
(
    Id INT IDENTITY(1,1) NOT NULL,
    Data NVARCHAR(MAX) NOT NULL,
    CONSTRAINT PK_QRCode PRIMARY KEY (Id)
);
GO

CREATE TABLE QRCodeApiSchema.Users
(
    Id INT IDENTITY(1,1) NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_Users PRIMARY KEY (Id)
);
GO

CREATE TABLE QRCodeApiSchema.Auth(
	[Email] [nvarchar](50) NULL,
	[PasswordHash] [varbinary](max) NULL,
	[PasswordSalt] [varbinary](max) NULL
);
GO