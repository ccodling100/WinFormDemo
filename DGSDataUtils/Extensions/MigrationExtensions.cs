﻿using System.Reflection;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DGSDataUtils.Extensions;

public static class MigrationExtensions
{
    public static void SqlFromFile(this MigrationBuilder builder, string filename)
    {
        if (string.IsNullOrEmpty(filename))
            throw new ArgumentException("Required parameter is missing.", nameof(filename));

        FileInfo assemblyInfo = new FileInfo(Assembly.GetExecutingAssembly().Location);
        string fullPath = Path.Combine(assemblyInfo.Directory.FullName, filename);

        if (File.Exists(fullPath))
        {
            string sql = File.ReadAllText(fullPath);
            string lf = Environment.NewLine; // For compilation on Windows or Linux
            builder.Sql($"EXEC sp_executesql N'{lf}{sql.Replace("'", "''")}{lf}'");
        }
        else
        {
            throw new FileNotFoundException("File not found.", fullPath);
        }
    }

    public static void CreateProcedure(this MigrationBuilder builder, string name, string schema, string filename, bool dropIfExists = true)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Required parameter is missing.", nameof(name));

        if (string.IsNullOrEmpty(filename))
            throw new ArgumentException("Required parameter is missing.", nameof(filename));

        if (dropIfExists) DropProcedure(builder, name, schema);

        SqlFromFile(builder, filename);
    }

    public static void DropProcedure(this MigrationBuilder builder, string name, string schema = null)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Required parameter is missing.", nameof(name));

        if (string.IsNullOrEmpty(schema))
            schema = "dbo";

        builder.Sql($"IF OBJECT_ID('[{schema}].[{name}]', 'P') IS NOT NULL DROP PROCEDURE [{schema}].[{name}]");
    }
}