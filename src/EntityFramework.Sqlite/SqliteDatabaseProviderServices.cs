// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Reflection;
using JetBrains.Annotations;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata.ModelConventions;
using Microsoft.Data.Entity.Relational;
using Microsoft.Data.Entity.Relational.Metadata;
using Microsoft.Data.Entity.Relational.Migrations.History;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using Microsoft.Data.Entity.Relational.Migrations.Sql;
using Microsoft.Data.Entity.Relational.Query.Methods;
using Microsoft.Data.Entity.Relational.Update;
using Microsoft.Data.Entity.Sqlite.Metadata;
using Microsoft.Data.Entity.Sqlite.Migrations;
using Microsoft.Data.Entity.Sqlite.Update;
using Microsoft.Data.Entity.Sqlite.ValueGeneration;
using Microsoft.Data.Entity.Storage;
using Microsoft.Data.Entity.ValueGeneration;

namespace Microsoft.Data.Entity.Sqlite
{
    public class SqliteDatabaseProviderServices : RelationalDatabaseProviderServices
    {
        public SqliteDatabaseProviderServices([NotNull] IServiceProvider services)
            : base(services)
        {
        }

        public override string InvariantName => GetType().GetTypeInfo().Assembly.GetName().Name;
        public override IDatabaseCreator Creator => GetService<SqliteDatabaseCreator>();
        public override IHistoryRepository HistoryRepository => GetService<SqliteHistoryRepository>();
        public override IMigrationSqlGenerator MigrationSqlGenerator => GetService<SqliteMigrationSqlGenerator>();
        public override IModelSource ModelSource => GetService<SqliteModelSource>();
        public override IRelationalConnection RelationalConnection => GetService<SqliteDatabaseConnection>();
        public override ISqlGenerator SqlGenerator => GetService<SqliteSqlGenerator>();
        public override IDatabase Database => GetService<SqliteDatabase>();
        public override IValueGeneratorCache ValueGeneratorCache => GetService<SqliteValueGeneratorCache>();
        public override IRelationalTypeMapper TypeMapper => GetService<SqliteTypeMapper>();
        public override IModificationCommandBatchFactory ModificationCommandBatchFactory => GetService<SqliteModificationCommandBatchFactory>();
        public override IRelationalDatabaseCreator RelationalDatabaseCreator => GetService<SqliteDatabaseCreator>();
        public override IConventionSetBuilder ConventionSetBuilder => GetService<SqliteConventionSetBuilder>();
        public override IRelationalMetadataExtensionProvider MetadataExtensionProvider => GetService<SqliteMetadataExtensionProvider>();
        public override IMethodCallTranslator CompositeMethodCallTranslator => GetService<SqliteCompositeMethodCallTranslator>();
        public override IMemberTranslator CompositeMemberTranslator => GetService<SqliteCompositeMemberTranslator>();
        public override IMigrationAnnotationProvider MigrationAnnotationProvider => GetService<SqliteMigrationAnnotationProvider>();
    }
}
