﻿// <auto-generated />
using System;
using Blog_Sitesi.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog_Sitesi.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240713171241_mig7")]
    partial class mig7
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blog_Sitesi.Models.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Teknolojik şeyler",
                            Name = "Teknoloji"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Sanat ve Kültür şeyler",
                            Name = "Sanat ve Kültür"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Kişisel Gelişim şeyler",
                            Name = "Kişisel Gelişim"
                        },
                        new
                        {
                            CategoryId = 4,
                            Description = "Eğitim ile ilgili konular",
                            Name = "Eğitim"
                        },
                        new
                        {
                            CategoryId = 5,
                            Description = "Sağlık teknolojileri ve sağlık hizmetleri",
                            Name = "Sağlık"
                        },
                        new
                        {
                            CategoryId = 6,
                            Description = "Seyahat ve turizm",
                            Name = "Seyahat"
                        },
                        new
                        {
                            CategoryId = 7,
                            Description = "Girişimcilik ve iş dünyası",
                            Name = "Girişimcilik"
                        },
                        new
                        {
                            CategoryId = 8,
                            Description = "Sosyal medya platformları ve etkileri",
                            Name = "Sosyal Medya"
                        },
                        new
                        {
                            CategoryId = 9,
                            Description = "Çevresel sürdürülebilirlik ve yeşil teknolojiler",
                            Name = "Çevre"
                        },
                        new
                        {
                            CategoryId = 10,
                            Description = "Finansal piyasalar ve yenilikçi finansal teknolojiler",
                            Name = "Finans"
                        },
                        new
                        {
                            CategoryId = 11,
                            Description = "Online ticaret platformları ve e-ticaret trendleri",
                            Name = "E-ticaret"
                        },
                        new
                        {
                            CategoryId = 12,
                            Description = "Mobil uygulama geliştirme ve mobil teknolojiler",
                            Name = "Mobil Uygulamalar"
                        },
                        new
                        {
                            CategoryId = 13,
                            Description = "Sanayi ve endüstriyel süreçlerdeki yenilikler",
                            Name = "Endüstri"
                        },
                        new
                        {
                            CategoryId = 14,
                            Description = "Veri analizi ve büyük veri teknolojileri",
                            Name = "Veri Bilimi"
                        });
                });

            modelBuilder.Entity("Blog_Sitesi.Models.Entities.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(140)
                        .HasColumnType("nvarchar(140)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int?>("PostId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            CommentId = 1,
                            Content = "çok güzeldi teşekkürler",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 787, DateTimeKind.Local).AddTicks(4212),
                            PostId = 1,
                            UserId = 2
                        },
                        new
                        {
                            CommentId = 2,
                            Content = "dostum naber",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 787, DateTimeKind.Local).AddTicks(4231),
                            PostId = 1,
                            UserId = 2
                        },
                        new
                        {
                            CommentId = 3,
                            Content = "vay canına",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 787, DateTimeKind.Local).AddTicks(4233),
                            PostId = 1,
                            UserId = 3
                        },
                        new
                        {
                            CommentId = 4,
                            Content = "çok bilgilendiriciydi",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 787, DateTimeKind.Local).AddTicks(4234),
                            PostId = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Blog_Sitesi.Models.Entities.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"));

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.HasIndex("PostId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            ImageId = 1,
                            PostId = 1,
                            Url = "https://letsenhance.io/static/8f5e523ee6b2479e26ecc91b9c25261e/1015f/MainAfter.jpg"
                        },
                        new
                        {
                            ImageId = 2,
                            PostId = 1,
                            Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTuWXzkIYkMaVY24lJLPWFRS3WKI3kB3Ls0bg&s"
                        },
                        new
                        {
                            ImageId = 3,
                            PostId = 2,
                            Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcREoRGyXmHy_6aIgXYqWHdOT3KjfmnuSyxypw&s"
                        });
                });

            modelBuilder.Entity("Blog_Sitesi.Models.Entities.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ViewCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("PostId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            CategoryId = 1,
                            Content = "bir şeyler bir şeyler",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(604),
                            Title = "başlık1",
                            UserId = 3,
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 2,
                            CategoryId = 2,
                            Content = "burada şunu anlatıyoruz",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(611),
                            Title = "başlık2",
                            UserId = 2,
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 3,
                            CategoryId = 1,
                            Content = "bu da böyle bir post",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(613),
                            Title = "başlık3",
                            UserId = 1,
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 4,
                            CategoryId = 3,
                            Content = "Yeni teknoloji trendleri üzerine düşüncelerimiz.",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(614),
                            Title = "Teknoloji Trendleri",
                            UserId = 2,
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 5,
                            CategoryId = 4,
                            Content = "Geleceğin eğitim sistemleri nasıl olacak?",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(616),
                            Title = "Geleceğin Eğitimi",
                            UserId = 3,
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 6,
                            CategoryId = 3,
                            Content = "Yazılım geliştirme süreçlerindeki en büyük zorluklarımız.",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(618),
                            Title = "Yazılım Geliştirme Zorlukları",
                            UserId = 1,
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 7,
                            CategoryId = 5,
                            Content = "Sağlık sektöründe yapay zeka kullanımı üzerine düşünceler.",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(620),
                            Title = "Yapay Zeka ve Sağlık",
                            UserId = 3,
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 8,
                            CategoryId = 6,
                            Content = "Geleceğin seyahat trendleri ve tahminlerimiz.",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(621),
                            Title = "Geleceğin Seyahatleri",
                            UserId = 2,
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 9,
                            CategoryId = 4,
                            Content = "Sanal gerçeklik teknolojilerinin eğitimdeki potansiyeli.",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(622),
                            Title = "Sanal Gerçeklik ve Eğitim",
                            UserId = 1,
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 10,
                            CategoryId = 7,
                            Content = "Girişimcilikte en önemli başarı faktörleri nelerdir?",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(624),
                            Title = "Girişimcilik Başarı Faktörleri",
                            UserId = 2,
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 11,
                            CategoryId = 8,
                            Content = "Sosyal medyanın geleceği ve değişen dinamikler.",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(626),
                            Title = "Sosyal Medyanın Geleceği",
                            UserId = 3,
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 12,
                            CategoryId = 5,
                            Content = "Yapay zeka ve otomasyonun endüstriyel etkileri üzerine bir değerlendirme.",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(628),
                            Title = "Yapay Zeka ve Endüstri",
                            UserId = 1,
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 13,
                            CategoryId = 9,
                            Content = "Çevresel sürdürülebilirlik ve iş dünyasındaki rolü.",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(630),
                            Title = "Çevresel Sürdürülebilirlik",
                            UserId = 2,
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 14,
                            CategoryId = 10,
                            Content = "Blockchain teknolojisinin finans sektöründeki yenilikçi kullanımları.",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(631),
                            Title = "Blockchain ve Finans",
                            UserId = 3,
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 15,
                            CategoryId = 11,
                            Content = "E-ticaretin geleceği ve değişen tüketici alışkanlıkları.",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(632),
                            Title = "E-ticaretin Geleceği",
                            UserId = 1,
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 16,
                            CategoryId = 12,
                            Content = "Yeni nesil mobil uygulama geliştirme trendleri üzerine düşünceler.",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(633),
                            Title = "Mobil Uygulama Trendleri",
                            UserId = 2,
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 17,
                            CategoryId = 5,
                            Content = "Yapay zeka ve günlük yaşam üzerindeki etkileri.",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(635),
                            Title = "Yapay Zeka ve Günlük Hayat",
                            UserId = 3,
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 18,
                            CategoryId = 9,
                            Content = "Geleceğin enerji ihtiyaçları ve sürdürülebilir enerji çözümleri.",
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 788, DateTimeKind.Local).AddTicks(637),
                            Title = "Geleceğin Enerji İhtiyaçları",
                            UserId = 1,
                            ViewCount = 0
                        });
                });

            modelBuilder.Entity("Blog_Sitesi.Models.Entities.PostTag", b =>
                {
                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTag");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            TagId = 2
                        },
                        new
                        {
                            PostId = 2,
                            TagId = 2
                        },
                        new
                        {
                            PostId = 2,
                            TagId = 3
                        },
                        new
                        {
                            PostId = 2,
                            TagId = 4
                        },
                        new
                        {
                            PostId = 3,
                            TagId = 4
                        },
                        new
                        {
                            PostId = 4,
                            TagId = 5
                        },
                        new
                        {
                            PostId = 4,
                            TagId = 6
                        },
                        new
                        {
                            PostId = 5,
                            TagId = 7
                        },
                        new
                        {
                            PostId = 6,
                            TagId = 5
                        },
                        new
                        {
                            PostId = 6,
                            TagId = 8
                        },
                        new
                        {
                            PostId = 7,
                            TagId = 9
                        },
                        new
                        {
                            PostId = 8,
                            TagId = 10
                        },
                        new
                        {
                            PostId = 9,
                            TagId = 7
                        },
                        new
                        {
                            PostId = 9,
                            TagId = 11
                        },
                        new
                        {
                            PostId = 10,
                            TagId = 12
                        },
                        new
                        {
                            PostId = 11,
                            TagId = 13
                        },
                        new
                        {
                            PostId = 12,
                            TagId = 14
                        },
                        new
                        {
                            PostId = 13,
                            TagId = 15
                        },
                        new
                        {
                            PostId = 14,
                            TagId = 16
                        },
                        new
                        {
                            PostId = 15,
                            TagId = 17
                        },
                        new
                        {
                            PostId = 16,
                            TagId = 18
                        },
                        new
                        {
                            PostId = 17,
                            TagId = 19
                        },
                        new
                        {
                            PostId = 18,
                            TagId = 20
                        });
                });

            modelBuilder.Entity("Blog_Sitesi.Models.Entities.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"));

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            TagId = 1,
                            TagName = "Yapay Zeka"
                        },
                        new
                        {
                            TagId = 2,
                            TagName = "Veri Bilimi"
                        },
                        new
                        {
                            TagId = 3,
                            TagName = "Web Geliştirme"
                        },
                        new
                        {
                            TagId = 4,
                            TagName = "Mobil Uygulamalar"
                        },
                        new
                        {
                            TagId = 5,
                            TagName = "Teknoloji Trendleri"
                        },
                        new
                        {
                            TagId = 6,
                            TagName = "Eğitim Sistemleri"
                        },
                        new
                        {
                            TagId = 7,
                            TagName = "Yazılım Geliştirme"
                        },
                        new
                        {
                            TagId = 8,
                            TagName = "Sanal Gerçeklik"
                        },
                        new
                        {
                            TagId = 9,
                            TagName = "Sağlık Teknolojileri"
                        },
                        new
                        {
                            TagId = 10,
                            TagName = "Seyahat Trendleri"
                        },
                        new
                        {
                            TagId = 11,
                            TagName = "Girişimcilik"
                        },
                        new
                        {
                            TagId = 12,
                            TagName = "Sosyal Medya"
                        },
                        new
                        {
                            TagId = 13,
                            TagName = "Endüstri 4.0"
                        },
                        new
                        {
                            TagId = 14,
                            TagName = "Çevresel Sürdürülebilirlik"
                        },
                        new
                        {
                            TagId = 15,
                            TagName = "Blockchain"
                        },
                        new
                        {
                            TagId = 16,
                            TagName = "E-ticaret"
                        },
                        new
                        {
                            TagId = 17,
                            TagName = "Mobil Uygulama Geliştirme"
                        },
                        new
                        {
                            TagId = 18,
                            TagName = "Yapay Zeka Günlük Hayat"
                        },
                        new
                        {
                            TagId = 19,
                            TagName = "Enerji İhtiyaçları"
                        },
                        new
                        {
                            TagId = 20,
                            TagName = "Veri Analitiği"
                        });
                });

            modelBuilder.Entity("Blog_Sitesi.Models.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("PeriodEnd")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("PeriodEnd");

                    b.Property<DateTime>("PeriodStart")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("PeriodStart");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.HasKey("UserId");

                    b.ToTable("Users", (string)null);

                    b.ToTable(tb => tb.IsTemporal(ttb =>
                            {
                                ttb.UseHistoryTable("UsersHistory");
                                ttb
                                    .HasPeriodStart("PeriodStart")
                                    .HasColumnName("PeriodStart");
                                ttb
                                    .HasPeriodEnd("PeriodEnd")
                                    .HasColumnName("PeriodEnd");
                            }));

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1775),
                            Email = "ahmet@gmail.com",
                            Name = "Ahmet",
                            Password = "123",
                            Role = "admin"
                        },
                        new
                        {
                            UserId = 2,
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1782),
                            Email = "mehmet@gmail.com",
                            Name = "Mehmet",
                            Password = "456",
                            Role = "user"
                        },
                        new
                        {
                            UserId = 3,
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1783),
                            Email = "ayse@gmail.com",
                            Name = "Ayşe",
                            Password = "789",
                            Role = "user"
                        },
                        new
                        {
                            UserId = 4,
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1785),
                            Email = "fatma@gmail.com",
                            Name = "Fatma",
                            Password = "abc",
                            Role = "user"
                        },
                        new
                        {
                            UserId = 5,
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1786),
                            Email = "mustafa@gmail.com",
                            Name = "Mustafa",
                            Password = "def",
                            Role = "user"
                        },
                        new
                        {
                            UserId = 6,
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1789),
                            Email = "zeynep@gmail.com",
                            Name = "Zeynep",
                            Password = "ghi",
                            Role = "user"
                        },
                        new
                        {
                            UserId = 7,
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1790),
                            Email = "ali@gmail.com",
                            Name = "Ali",
                            Password = "jkl",
                            Role = "user"
                        },
                        new
                        {
                            UserId = 8,
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1792),
                            Email = "aysel@gmail.com",
                            Name = "Aysel",
                            Password = "mno",
                            Role = "user"
                        },
                        new
                        {
                            UserId = 9,
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1793),
                            Email = "ismail@gmail.com",
                            Name = "İsmail",
                            Password = "pqr",
                            Role = "user"
                        },
                        new
                        {
                            UserId = 10,
                            CreatedAt = new DateTime(2024, 7, 13, 20, 12, 40, 789, DateTimeKind.Local).AddTicks(1823),
                            Email = "hulya@gmail.com",
                            Name = "Hülya",
                            Password = "stu",
                            Role = "user"
                        });
                });

            modelBuilder.Entity("Blog_Sitesi.Models.Entities.Comment", b =>
                {
                    b.HasOne("Blog_Sitesi.Models.Entities.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .HasConstraintName("PostId");

                    b.HasOne("Blog_Sitesi.Models.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .HasConstraintName("UserId");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Blog_Sitesi.Models.Entities.Image", b =>
                {
                    b.HasOne("Blog_Sitesi.Models.Entities.Post", "Post")
                        .WithMany("Images")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("Blog_Sitesi.Models.Entities.Post", b =>
                {
                    b.HasOne("Blog_Sitesi.Models.Entities.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog_Sitesi.Models.Entities.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Blog_Sitesi.Models.Entities.PostTag", b =>
                {
                    b.HasOne("Blog_Sitesi.Models.Entities.Post", "Post")
                        .WithMany("Tags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog_Sitesi.Models.Entities.Tag", "Tag")
                        .WithMany("Posts")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Blog_Sitesi.Models.Entities.Category", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("Blog_Sitesi.Models.Entities.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Images");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("Blog_Sitesi.Models.Entities.Tag", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("Blog_Sitesi.Models.Entities.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
