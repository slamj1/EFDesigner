//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace Testing
{
   public partial class AllFeatureModel : System.Data.Entity.DbContext
   {
      public System.Data.Entity.DbSet<Testing.AbstractBaseClass> AbstractBaseClasses { get; set; }
      public System.Data.Entity.DbSet<Testing.AllPropertyTypesOptional> AllPropertyTypesOptionals { get; set; }
      public System.Data.Entity.DbSet<Testing.AllPropertyTypesRequired> AllPropertyTypesRequireds { get; set; }
      public System.Data.Entity.DbSet<Testing.BaseClass> BaseClasses { get; set; }
      public System.Data.Entity.DbSet<Testing.BaseClassWithRequiredProperties> BaseClassWithRequiredProperties { get; set; }
      public System.Data.Entity.DbSet<Testing.BChild> BChilds { get; set; }
      public System.Data.Entity.DbSet<Testing.BParentCollection> BParentCollections { get; set; }
      public System.Data.Entity.DbSet<Testing.BParentOptional> BParentOptionals { get; set; }
      public System.Data.Entity.DbSet<Testing.BParentRequired> BParentRequireds { get; set; }
      public System.Data.Entity.DbSet<Testing.Child> Children { get; set; }
      public System.Data.Entity.DbSet<Testing.ConcreteDerivedClass> ConcreteDerivedClasses { get; set; }
      public System.Data.Entity.DbSet<Testing.ConcreteDerivedClassWithRequiredProperties> ConcreteDerivedClassWithRequiredProperties { get; set; }
      public System.Data.Entity.DbSet<Testing.DerivedClass> DerivedClasses { get; set; }
      public System.Data.Entity.DbSet<Testing.HiddenEntity> HiddenEntities { get; set; }
      public System.Data.Entity.DbSet<Testing.Master> Masters { get; set; }
      public System.Data.Entity.DbSet<Testing.ParserTest> ParserTests { get; set; }
      public System.Data.Entity.DbSet<Testing.UChild> UChilds { get; set; }
      public System.Data.Entity.DbSet<Testing.UParentCollection> UParentCollections { get; set; }
      public System.Data.Entity.DbSet<Testing.UParentOptional> UParentOptionals { get; set; }
      public System.Data.Entity.DbSet<Testing.UParentRequired> UParentRequireds { get; set; }

      public static string ConnectionString { get; set; } = @"Data Source=.\sqlexpress;Initial Catalog=Test;Integrated Security=True";
      public AllFeatureModel() : base(ConnectionString)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<AllFeatureModel>(null);
         CustomInit();
      }

      public AllFeatureModel(string connectionString) : base(connectionString)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<AllFeatureModel>(null);
         CustomInit();
      }

      public AllFeatureModel(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<AllFeatureModel>(null);
         CustomInit();
      }

      public AllFeatureModel(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<AllFeatureModel>(null);
         CustomInit();
      }

      public AllFeatureModel(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<AllFeatureModel>(null);
         CustomInit();
      }

      partial void CustomInit();
      partial void OnModelCreatingImpl(System.Data.Entity.DbModelBuilder modelBuilder);
      partial void OnModelCreatedImpl(System.Data.Entity.DbModelBuilder modelBuilder);

      protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);
         OnModelCreatingImpl(modelBuilder);

         modelBuilder.HasDefaultSchema("dbo");


         modelBuilder.Entity<Testing.AllPropertyTypesOptional>().ToTable("AllPropertyTypesOptionals").HasKey(t => t.Id);
         modelBuilder.Entity<Testing.AllPropertyTypesOptional>().Property(t => t.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         modelBuilder.Entity<Testing.AllPropertyTypesOptional>().Property(t => t.String).HasMaxLength(100);

         modelBuilder.Entity<Testing.AllPropertyTypesRequired>().ToTable("AllPropertyTypesRequireds").HasKey(t => t.Id);
         modelBuilder.Entity<Testing.AllPropertyTypesRequired>().Property(t => t.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         modelBuilder.Entity<Testing.AllPropertyTypesRequired>().Property(t => t.BinaryAttr).IsRequired();
         modelBuilder.Entity<Testing.AllPropertyTypesRequired>().Property(t => t.BooleanAttr).IsRequired();
         modelBuilder.Entity<Testing.AllPropertyTypesRequired>().Property(t => t.ByteAttr).IsRequired();
         modelBuilder.Entity<Testing.AllPropertyTypesRequired>().Property(t => t.DateTimeAttr).IsRequired();
         modelBuilder.Entity<Testing.AllPropertyTypesRequired>().Property(t => t.DateTimeOffsetAttr).IsRequired();
         modelBuilder.Entity<Testing.AllPropertyTypesRequired>().Property(t => t.DecimalAttr).IsRequired();
         modelBuilder.Entity<Testing.AllPropertyTypesRequired>().Property(t => t.DoubleAttr).IsRequired();
         modelBuilder.Entity<Testing.AllPropertyTypesRequired>().Property(t => t.GuidAttr).IsRequired();
         modelBuilder.Entity<Testing.AllPropertyTypesRequired>().Property(t => t.Int16Attr).IsRequired();
         modelBuilder.Entity<Testing.AllPropertyTypesRequired>().Property(t => t.Int32Attr).IsRequired();
         modelBuilder.Entity<Testing.AllPropertyTypesRequired>().Property(t => t.Int64Attr).IsRequired();
         modelBuilder.Entity<Testing.AllPropertyTypesRequired>().Property(t => t.SingleAttr).IsRequired();
         modelBuilder.Entity<Testing.AllPropertyTypesRequired>().Property(t => t.TimeAttr).IsRequired();
         modelBuilder.Entity<Testing.AllPropertyTypesRequired>().Property(t => t.String).HasMaxLength(100).IsRequired();


         modelBuilder.Entity<Testing.BaseClassWithRequiredProperties>().ToTable("BaseClassWithRequiredProperties").HasKey(t => t.Id);
         modelBuilder.Entity<Testing.BaseClassWithRequiredProperties>().Property(t => t.Id).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute())).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         modelBuilder.Entity<Testing.BaseClassWithRequiredProperties>().Property(t => t.Property0).IsRequired();

         modelBuilder.Entity<Testing.BChild>().ToTable("BChilds").HasKey(t => t.Id);
         modelBuilder.Entity<Testing.BChild>().Property(t => t.Id).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute())).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         modelBuilder.Entity<Testing.BChild>().HasRequired(x => x.BParentRequired).WithOptional(x => x.BChildOptional).Map(x => x.MapKey("BParentRequired_Id")).WillCascadeOnDelete();
         modelBuilder.Entity<Testing.BChild>().HasRequired(x => x.BParentRequired_1).WithRequiredPrincipal(x => x.BChildRequired).Map(x => x.MapKey("BParentRequired_1_Id")).WillCascadeOnDelete();
         modelBuilder.Entity<Testing.BChild>().HasRequired(x => x.BParentRequired_2).WithMany(x => x.BChildCollection).Map(x => x.MapKey("BParentRequired_2_Id")).WillCascadeOnDelete();
         modelBuilder.Entity<Testing.BChild>().HasMany(x => x.BParentCollection).WithRequired(x => x.BChildRequired).Map(x => x.MapKey("BChildRequired_Id")).WillCascadeOnDelete();
         modelBuilder.Entity<Testing.BChild>().HasMany(x => x.BParentCollection_1).WithMany(x => x.BChildCollection).Map(x => { x.ToTable("BParentCollection_1_x_BChildCollection"); x.MapLeftKey("BParentCollection_Id"); x.MapRightKey("BChild_Id"); });
         modelBuilder.Entity<Testing.BChild>().HasMany(x => x.BParentCollection_2).WithOptional(x => x.BChildOptional).Map(x => x.MapKey("BChildOptional_Id"));
         modelBuilder.Entity<Testing.BChild>().HasOptional(x => x.BParentOptional).WithRequired(x => x.BChildRequired).Map(x => x.MapKey("BChildRequired1_Id")).WillCascadeOnDelete();
         modelBuilder.Entity<Testing.BChild>().HasOptional(x => x.BParentOptional_1).WithMany(x => x.BChildCollection).Map(x => x.MapKey("BParentOptional_1_Id"));
         modelBuilder.Entity<Testing.BChild>().HasOptional(x => x.BParentOptional_2).WithOptionalPrincipal(x => x.BChildOptional).Map(x => x.MapKey("BParentOptional_2_Id"));

         modelBuilder.Entity<Testing.BParentCollection>().ToTable("BParentCollections").HasKey(t => t.Id);
         modelBuilder.Entity<Testing.BParentCollection>().Property(t => t.Id).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute())).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

         modelBuilder.Entity<Testing.BParentOptional>().ToTable("BParentOptionals").HasKey(t => t.Id);
         modelBuilder.Entity<Testing.BParentOptional>().Property(t => t.Id).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute())).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

         modelBuilder.Entity<Testing.BParentRequired>().ToTable("BParentRequireds").HasKey(t => t.Id);
         modelBuilder.Entity<Testing.BParentRequired>().Property(t => t.Id).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute())).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

         modelBuilder.Entity<Testing.Child>().ToTable("Children").HasKey(t => t.Id);
         modelBuilder.Entity<Testing.Child>().Property(t => t.Id).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute())).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         modelBuilder.Entity<Testing.Child>().HasRequired(x => x.Parent).WithMany(x => x.Children).Map(x => x.MapKey("Parent_Id")).WillCascadeOnDelete();


         modelBuilder.Entity<Testing.ConcreteDerivedClassWithRequiredProperties>().Property(t => t.Property1).IsRequired();


         modelBuilder.Entity<Testing.HiddenEntity>().ToTable("HiddenEntities").HasKey(t => t.Id);
         modelBuilder.Entity<Testing.HiddenEntity>().Property(t => t.Id).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute())).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

         modelBuilder.Entity<Testing.Master>().ToTable("Masters").HasKey(t => t.Id);
         modelBuilder.Entity<Testing.Master>().Property(t => t.Id).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute())).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         modelBuilder.Entity<Testing.Master>().HasMany(x => x.Children).WithRequired().Map(x => x.MapKey("Master_Id")).WillCascadeOnDelete();

         modelBuilder.Entity<Testing.ParserTest>().ToTable("ParserTests").HasKey(t => t.Id);
         modelBuilder.Entity<Testing.ParserTest>().Property(t => t.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         modelBuilder.Entity<Testing.ParserTest>().Property(t => t.foo).IsRequired();
         modelBuilder.Entity<Testing.ParserTest>().Property(t => t.name7).HasMaxLength(6);
         modelBuilder.Entity<Testing.ParserTest>().Property(t => t.name8).HasMaxLength(6);
         modelBuilder.Entity<Testing.ParserTest>().Property(t => t.name9).HasMaxLength(6);
         modelBuilder.Entity<Testing.ParserTest>().Property(t => t.name).HasMaxLength(6);
         modelBuilder.Entity<Testing.ParserTest>().Property(t => t.name15).HasMaxLength(6);
         modelBuilder.Entity<Testing.ParserTest>().Property(t => t.name16).HasMaxLength(6);
         modelBuilder.Entity<Testing.ParserTest>().Property(t => t.name17).HasMaxLength(6);
         modelBuilder.Entity<Testing.ParserTest>().Property(t => t.name18).HasMaxLength(6);

         modelBuilder.Entity<Testing.UChild>().ToTable("UChilds").HasKey(t => t.Id);
         modelBuilder.Entity<Testing.UChild>().Property(t => t.Id).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute())).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

         modelBuilder.Entity<Testing.UParentCollection>().ToTable("UParentCollections").HasKey(t => t.Id);
         modelBuilder.Entity<Testing.UParentCollection>().Property(t => t.Id).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute())).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         modelBuilder.Entity<Testing.UParentCollection>().HasRequired(x => x.UChildRequired).WithMany().Map(x => x.MapKey("UChildRequired_Id")).WillCascadeOnDelete();
         modelBuilder.Entity<Testing.UParentCollection>().HasMany(x => x.UChildCollection).WithMany().Map(x => { x.ToTable("UParentCollection_x_UChildCollection"); x.MapLeftKey("UParentCollection_Id"); x.MapRightKey("UChild_Id"); });
         modelBuilder.Entity<Testing.UParentCollection>().HasOptional(x => x.UChildOptional).WithMany().Map(x => x.MapKey("UChildOptional_Id"));

         modelBuilder.Entity<Testing.UParentOptional>().HasOptional(x => x.UChildOptional).WithOptionalDependent().Map(x => x.MapKey("UParentOptional_Id"));
         modelBuilder.Entity<Testing.UParentOptional>().HasMany(x => x.UChildCollection).WithOptional().Map(x => x.MapKey("UParentOptional1_Id"));
         modelBuilder.Entity<Testing.UParentOptional>().HasRequired(x => x.UChildRequired).WithOptional().Map(x => x.MapKey("UChildRequired_Id")).WillCascadeOnDelete();

         modelBuilder.Entity<Testing.UParentRequired>().ToTable("UParentRequireds").HasKey(t => t.Id);
         modelBuilder.Entity<Testing.UParentRequired>().Property(t => t.Id).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute())).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         modelBuilder.Entity<Testing.UParentRequired>().HasRequired(x => x.UChildRequired).WithRequiredDependent().Map(x => x.MapKey("UParentRequired_Id")).WillCascadeOnDelete();
         modelBuilder.Entity<Testing.UParentRequired>().HasMany(x => x.UChildCollection).WithRequired().Map(x => x.MapKey("UParentRequired1_Id")).WillCascadeOnDelete();
         modelBuilder.Entity<Testing.UParentRequired>().HasOptional(x => x.UChildOptional).WithRequired().Map(x => x.MapKey("UParentRequired2_Id")).WillCascadeOnDelete();

         OnModelCreatedImpl(modelBuilder);
      }
   }
}
