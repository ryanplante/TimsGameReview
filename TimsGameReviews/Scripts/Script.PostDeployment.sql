/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
if not exists (select * from dbo.Genre)
begin
    insert into dbo.Genre([Name])
    values
    ('Horror'),
    ('Shooter'),
    ('RPG'),
    ('Open World'),
    ('Racing');
end


if not exists (select * from dbo.VideoGame)
begin
    insert into dbo.VideoGame([Title], [Description], [Price], [Genre])
    values 
    ('Grand Theft Auto Switch Edition', 'PG Rated crime game for kids!', 65.00, 2),
    ('Cookie Clicker', 'Keep clicking those cookies!', 1.00, 5),
    ('The Legend of Zelda Playstation Edition', 'Zelda but sony made it', 70.00, 4); 
end

if not exists (select * from dbo.Users)
begin
    insert into dbo.Users([UName], [PermissionLevel], [Password])
    values
    ('Admin', 2, 'Password'),
    ('User', 1, 'password'),
    ('User1', 1, 'password');
end