
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/26/2018 16:20:48
-- Generated from EDMX file: C:\Users\Administrator.WIN10-710012008\Source\Repos\OjExam3\OjExam.Model\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [OjExam];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClassStudent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Student] DROP CONSTRAINT [FK_ClassStudent];
GO
IF OBJECT_ID(N'[dbo].[FK_ClassTeacherCourserClass]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClassTeacherCourser] DROP CONSTRAINT [FK_ClassTeacherCourserClass];
GO
IF OBJECT_ID(N'[dbo].[FK_ClassTeacherCourserCourser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClassTeacherCourser] DROP CONSTRAINT [FK_ClassTeacherCourserCourser];
GO
IF OBJECT_ID(N'[dbo].[FK_ClassTeacherCourserTeacher]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClassTeacherCourser] DROP CONSTRAINT [FK_ClassTeacherCourserTeacher];
GO
IF OBJECT_ID(N'[dbo].[FK_ExamClassTeacherCourser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExamSet] DROP CONSTRAINT [FK_ExamClassTeacherCourser];
GO
IF OBJECT_ID(N'[dbo].[FK_CourserKnowPoint]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KnowPointSet] DROP CONSTRAINT [FK_CourserKnowPoint];
GO
IF OBJECT_ID(N'[dbo].[FK_GradeExam]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Grade] DROP CONSTRAINT [FK_GradeExam];
GO
IF OBJECT_ID(N'[dbo].[FK_GradeStudent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Grade] DROP CONSTRAINT [FK_GradeStudent];
GO
IF OBJECT_ID(N'[dbo].[FK_KnowPointProblem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Problem] DROP CONSTRAINT [FK_KnowPointProblem];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AdminSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AdminSet];
GO
IF OBJECT_ID(N'[dbo].[Class]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Class];
GO
IF OBJECT_ID(N'[dbo].[ClassTeacherCourser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClassTeacherCourser];
GO
IF OBJECT_ID(N'[dbo].[Courser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Courser];
GO
IF OBJECT_ID(N'[dbo].[ExamSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExamSet];
GO
IF OBJECT_ID(N'[dbo].[Grade]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Grade];
GO
IF OBJECT_ID(N'[dbo].[KnowPointSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KnowPointSet];
GO
IF OBJECT_ID(N'[dbo].[Problem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Problem];
GO
IF OBJECT_ID(N'[dbo].[StatusSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StatusSet];
GO
IF OBJECT_ID(N'[dbo].[Student]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Student];
GO
IF OBJECT_ID(N'[dbo].[Teacher]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Teacher];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AdminSet'
CREATE TABLE [dbo].[AdminSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LName] nvarchar(max)  NOT NULL,
    [Pwd] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [DelFlag] smallint  NOT NULL
);
GO

-- Creating table 'Class'
CREATE TABLE [dbo].[Class] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [Remarks] nvarchar(max)  NOT NULL,
    [DelFlag] smallint  NOT NULL
);
GO

-- Creating table 'ClassTeacherCourser'
CREATE TABLE [dbo].[ClassTeacherCourser] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TeacherId] int  NOT NULL,
    [ClassId] int  NOT NULL,
    [CourserId] int  NOT NULL,
    [DelFlag] smallint  NOT NULL
);
GO

-- Creating table 'Courser'
CREATE TABLE [dbo].[Courser] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [Remarks] nvarchar(max)  NOT NULL,
    [DelFlag] smallint  NOT NULL
);
GO

-- Creating table 'ExamSet'
CREATE TABLE [dbo].[ExamSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CTCId] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [StartTime] nvarchar(max)  NOT NULL,
    [EndTime] nvarchar(max)  NOT NULL,
    [Rank] nvarchar(max)  NOT NULL,
    [ClassTeacherCourser_Id] int  NOT NULL,
    [DelFlag] smallint  NOT NULL
);
GO

-- Creating table 'Grade'
CREATE TABLE [dbo].[Grade] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Score] nvarchar(max)  NOT NULL,
    [StudentId] int  NOT NULL,
    [ExamId] int  NOT NULL,
    [Problems] nvarchar(max)  NOT NULL,
    [Answers] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [DelFlag] smallint  NOT NULL
);
GO

-- Creating table 'KnowPointSet'
CREATE TABLE [dbo].[KnowPointSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Remarks] nvarchar(max)  NOT NULL,
    [CourserId] int  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [DelFlag] smallint  NOT NULL
);
GO

-- Creating table 'Problem'
CREATE TABLE [dbo].[Problem] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Src] nvarchar(max)  NOT NULL,
    [Answer] nvarchar(max)  NOT NULL,
    [KnowPointId] int  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [Rank] nvarchar(max)  NOT NULL,
    [DelFlag] smallint  NOT NULL
);
GO

-- Creating table 'StatusSet'
CREATE TABLE [dbo].[StatusSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Remarks] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Student'
CREATE TABLE [dbo].[Student] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StuId] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [IDcard] nvarchar(max)  NOT NULL,
    [Status] int  NOT NULL,
    [Pwd] nvarchar(max)  NOT NULL,
    [ClassId] int  NOT NULL,
    [DelFlag] smallint  NOT NULL
);
GO

-- Creating table 'Teacher'
CREATE TABLE [dbo].[Teacher] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TeaId] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [IDcard] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [Pwd] nvarchar(max)  NOT NULL,
    [DelFlag] smallint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AdminSet'
ALTER TABLE [dbo].[AdminSet]
ADD CONSTRAINT [PK_AdminSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Class'
ALTER TABLE [dbo].[Class]
ADD CONSTRAINT [PK_Class]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClassTeacherCourser'
ALTER TABLE [dbo].[ClassTeacherCourser]
ADD CONSTRAINT [PK_ClassTeacherCourser]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Courser'
ALTER TABLE [dbo].[Courser]
ADD CONSTRAINT [PK_Courser]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ExamSet'
ALTER TABLE [dbo].[ExamSet]
ADD CONSTRAINT [PK_ExamSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Grade'
ALTER TABLE [dbo].[Grade]
ADD CONSTRAINT [PK_Grade]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'KnowPointSet'
ALTER TABLE [dbo].[KnowPointSet]
ADD CONSTRAINT [PK_KnowPointSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Problem'
ALTER TABLE [dbo].[Problem]
ADD CONSTRAINT [PK_Problem]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StatusSet'
ALTER TABLE [dbo].[StatusSet]
ADD CONSTRAINT [PK_StatusSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Student'
ALTER TABLE [dbo].[Student]
ADD CONSTRAINT [PK_Student]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Teacher'
ALTER TABLE [dbo].[Teacher]
ADD CONSTRAINT [PK_Teacher]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClassId] in table 'Student'
ALTER TABLE [dbo].[Student]
ADD CONSTRAINT [FK_ClassStudent]
    FOREIGN KEY ([ClassId])
    REFERENCES [dbo].[Class]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClassStudent'
CREATE INDEX [IX_FK_ClassStudent]
ON [dbo].[Student]
    ([ClassId]);
GO

-- Creating foreign key on [ClassId] in table 'ClassTeacherCourser'
ALTER TABLE [dbo].[ClassTeacherCourser]
ADD CONSTRAINT [FK_ClassTeacherCourserClass]
    FOREIGN KEY ([ClassId])
    REFERENCES [dbo].[Class]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClassTeacherCourserClass'
CREATE INDEX [IX_FK_ClassTeacherCourserClass]
ON [dbo].[ClassTeacherCourser]
    ([ClassId]);
GO

-- Creating foreign key on [CourserId] in table 'ClassTeacherCourser'
ALTER TABLE [dbo].[ClassTeacherCourser]
ADD CONSTRAINT [FK_ClassTeacherCourserCourser]
    FOREIGN KEY ([CourserId])
    REFERENCES [dbo].[Courser]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClassTeacherCourserCourser'
CREATE INDEX [IX_FK_ClassTeacherCourserCourser]
ON [dbo].[ClassTeacherCourser]
    ([CourserId]);
GO

-- Creating foreign key on [TeacherId] in table 'ClassTeacherCourser'
ALTER TABLE [dbo].[ClassTeacherCourser]
ADD CONSTRAINT [FK_ClassTeacherCourserTeacher]
    FOREIGN KEY ([TeacherId])
    REFERENCES [dbo].[Teacher]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClassTeacherCourserTeacher'
CREATE INDEX [IX_FK_ClassTeacherCourserTeacher]
ON [dbo].[ClassTeacherCourser]
    ([TeacherId]);
GO

-- Creating foreign key on [ClassTeacherCourser_Id] in table 'ExamSet'
ALTER TABLE [dbo].[ExamSet]
ADD CONSTRAINT [FK_ExamClassTeacherCourser]
    FOREIGN KEY ([ClassTeacherCourser_Id])
    REFERENCES [dbo].[ClassTeacherCourser]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExamClassTeacherCourser'
CREATE INDEX [IX_FK_ExamClassTeacherCourser]
ON [dbo].[ExamSet]
    ([ClassTeacherCourser_Id]);
GO

-- Creating foreign key on [CourserId] in table 'KnowPointSet'
ALTER TABLE [dbo].[KnowPointSet]
ADD CONSTRAINT [FK_CourserKnowPoint]
    FOREIGN KEY ([CourserId])
    REFERENCES [dbo].[Courser]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourserKnowPoint'
CREATE INDEX [IX_FK_CourserKnowPoint]
ON [dbo].[KnowPointSet]
    ([CourserId]);
GO

-- Creating foreign key on [ExamId] in table 'Grade'
ALTER TABLE [dbo].[Grade]
ADD CONSTRAINT [FK_GradeExam]
    FOREIGN KEY ([ExamId])
    REFERENCES [dbo].[ExamSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GradeExam'
CREATE INDEX [IX_FK_GradeExam]
ON [dbo].[Grade]
    ([ExamId]);
GO

-- Creating foreign key on [StudentId] in table 'Grade'
ALTER TABLE [dbo].[Grade]
ADD CONSTRAINT [FK_GradeStudent]
    FOREIGN KEY ([StudentId])
    REFERENCES [dbo].[Student]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GradeStudent'
CREATE INDEX [IX_FK_GradeStudent]
ON [dbo].[Grade]
    ([StudentId]);
GO

-- Creating foreign key on [KnowPointId] in table 'Problem'
ALTER TABLE [dbo].[Problem]
ADD CONSTRAINT [FK_KnowPointProblem]
    FOREIGN KEY ([KnowPointId])
    REFERENCES [dbo].[KnowPointSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KnowPointProblem'
CREATE INDEX [IX_FK_KnowPointProblem]
ON [dbo].[Problem]
    ([KnowPointId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------