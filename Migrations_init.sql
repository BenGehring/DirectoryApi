IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [Listings] (
    [Id] bigint NOT NULL IDENTITY(-9223372036854775808, 1),
    [BusinessName] nvarchar(max) NULL,
    [Slug] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [CategoryId] int NOT NULL,
    [AddressLine1] nvarchar(max) NULL,
    [AddressLine2] nvarchar(max) NULL,
    [City] nvarchar(max) NULL,
    [StateProvince] nvarchar(max) NULL,
    [PostalCode] nvarchar(max) NULL,
    [Country] nvarchar(max) NULL,
    [Phone] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [WebsiteUrl] nvarchar(max) NULL,
    [SocialFacebook] nvarchar(max) NULL,
    [SocialInstagram] nvarchar(max) NULL,
    [SocialTwitter] nvarchar(max) NULL,
    [LogoUrl] nvarchar(max) NULL,
    [Images] nvarchar(max) NULL,
    [Latitude] decimal(18,2) NULL,
    [Longitude] decimal(18,2) NULL,
    [IsVerified] bit NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    [Status] nvarchar(max) NULL,
    [OwnerUserId] int NULL,
    CONSTRAINT [PK_Listings] PRIMARY KEY ([Id])
);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250511211851_init', N'9.0.4');

COMMIT;
GO

