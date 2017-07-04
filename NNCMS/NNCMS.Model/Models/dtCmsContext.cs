using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NNCMS.Model.Models
{
    public partial class dtCmsContext : DbContext
    {
        public dtCmsContext(DbContextOptions<dtCmsContext> options): base(options){ }

        public virtual DbSet<DtArticle> DtArticle { get; set; }
        public virtual DbSet<DtArticleAlbums> DtArticleAlbums { get; set; }
        public virtual DbSet<DtArticleAttach> DtArticleAttach { get; set; }
        public virtual DbSet<DtArticleAttributeField> DtArticleAttributeField { get; set; }
        public virtual DbSet<DtArticleAttributeValue> DtArticleAttributeValue { get; set; }
        public virtual DbSet<DtArticleCategory> DtArticleCategory { get; set; }
        public virtual DbSet<DtArticleComment> DtArticleComment { get; set; }
        public virtual DbSet<DtChannel> DtChannel { get; set; }
        public virtual DbSet<DtChannelField> DtChannelField { get; set; }
        public virtual DbSet<DtChannelSite> DtChannelSite { get; set; }
        public virtual DbSet<DtExpress> DtExpress { get; set; }
        public virtual DbSet<DtFeedback> DtFeedback { get; set; }
        public virtual DbSet<DtLink> DtLink { get; set; }
        public virtual DbSet<DtMailTemplate> DtMailTemplate { get; set; }
        public virtual DbSet<DtManager> DtManager { get; set; }
        public virtual DbSet<DtManagerLog> DtManagerLog { get; set; }
        public virtual DbSet<DtManagerRole> DtManagerRole { get; set; }
        public virtual DbSet<DtManagerRoleValue> DtManagerRoleValue { get; set; }
        public virtual DbSet<DtNavigation> DtNavigation { get; set; }
        public virtual DbSet<DtOrderGoods> DtOrderGoods { get; set; }
        public virtual DbSet<DtOrders> DtOrders { get; set; }
        public virtual DbSet<DtPayment> DtPayment { get; set; }
        public virtual DbSet<DtSmsTemplate> DtSmsTemplate { get; set; }
        public virtual DbSet<DtUserAmountLog> DtUserAmountLog { get; set; }
        public virtual DbSet<DtUserAttachLog> DtUserAttachLog { get; set; }
        public virtual DbSet<DtUserCode> DtUserCode { get; set; }
        public virtual DbSet<DtUserGroupPrice> DtUserGroupPrice { get; set; }
        public virtual DbSet<DtUserGroups> DtUserGroups { get; set; }
        public virtual DbSet<DtUserLoginLog> DtUserLoginLog { get; set; }
        public virtual DbSet<DtUserMessage> DtUserMessage { get; set; }
        public virtual DbSet<DtUserOauth> DtUserOauth { get; set; }
        public virtual DbSet<DtUserOauthApp> DtUserOauthApp { get; set; }
        public virtual DbSet<DtUserPointLog> DtUserPointLog { get; set; }
        public virtual DbSet<DtUserRecharge> DtUserRecharge { get; set; }
        public virtual DbSet<DtUsers> DtUsers { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //    optionsBuilder.UseSqlServer(@"Server=.;Database=dtCms;Trusted_Connection=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DtArticle>(entity =>
            {
                entity.ToTable("dt_article");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CallIndex)
                    .HasColumnName("call_index")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChannelId)
                    .HasColumnName("channel_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Click)
                    .HasColumnName("click")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("ntext");

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("img_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsHot)
                    .HasColumnName("is_hot")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsMsg)
                    .HasColumnName("is_msg")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsRed)
                    .HasColumnName("is_red")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsSlide)
                    .HasColumnName("is_slide")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsSys)
                    .HasColumnName("is_sys")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsTop)
                    .HasColumnName("is_top")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("link_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SeoDescription)
                    .HasColumnName("seo_description")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SeoKeywords)
                    .HasColumnName("seo_keywords")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SeoTitle)
                    .HasColumnName("seo_title")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tags)
                    .HasColumnName("tags")
                    .HasMaxLength(500);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Zhaiyao)
                    .HasColumnName("zhaiyao")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DtArticleAlbums>(entity =>
            {
                entity.ToTable("dt_article_albums");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OriginalPath)
                    .HasColumnName("original_path")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ThumbPath)
                    .HasColumnName("thumb_path")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DtArticleAttach>(entity =>
            {
                entity.ToTable("dt_article_attach");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DownNum)
                    .HasColumnName("down_num")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FileExt)
                    .HasColumnName("file_ext")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FilePath)
                    .HasColumnName("file_path")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FileSize)
                    .HasColumnName("file_size")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DtArticleAttributeField>(entity =>
            {
                entity.ToTable("dt_article_attribute_field");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ControlType)
                    .HasColumnName("control_type")
                    .HasMaxLength(50);

                entity.Property(e => e.DataLength)
                    .HasColumnName("data_length")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DataPlace)
                    .HasColumnName("data_place")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(50);

                entity.Property(e => e.DefaultValue)
                    .HasColumnName("default_value")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EditorType)
                    .HasColumnName("editor_type")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsHtml)
                    .HasColumnName("is_html")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsPassword)
                    .HasColumnName("is_password")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsRequired)
                    .HasColumnName("is_required")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsSys)
                    .HasColumnName("is_sys")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemOption)
                    .HasColumnName("item_option")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ValidErrorMsg)
                    .HasColumnName("valid_error_msg")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ValidPattern)
                    .HasColumnName("valid_pattern")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ValidTipMsg)
                    .HasColumnName("valid_tip_msg")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DtArticleAttributeValue>(entity =>
            {
                entity.HasKey(e => e.ArticleId)
                    .HasName("PK_DT_ARTICLE_ATTRIBUTE_VALUE");

                entity.ToTable("dt_article_attribute_value");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasMaxLength(50);

                entity.Property(e => e.GoodsNo)
                    .HasColumnName("goods_no")
                    .HasMaxLength(100);

                entity.Property(e => e.MarketPrice)
                    .HasColumnName("market_price")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SellPrice)
                    .HasColumnName("sell_price")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(100);

                entity.Property(e => e.StockQuantity)
                    .HasColumnName("stock_quantity")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubTitle)
                    .HasColumnName("sub_title")
                    .HasMaxLength(255);

                entity.Property(e => e.VideoSrc)
                    .HasColumnName("video_src")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Article)
                    .WithOne(p => p.DtArticleAttributeValue)
                    .HasForeignKey<DtArticleAttributeValue>(d => d.ArticleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DT_ARTIC_REFERENCE_DT_ARTIC");
            });

            modelBuilder.Entity<DtArticleCategory>(entity =>
            {
                entity.ToTable("dt_article_category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CallIndex)
                    .HasColumnName("call_index")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ChannelId).HasColumnName("channel_id");

                entity.Property(e => e.ClassLayer)
                    .HasColumnName("class_layer")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClassList)
                    .HasColumnName("class_list")
                    .HasMaxLength(500);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("ntext");

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("img_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("link_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SeoDescription)
                    .HasColumnName("seo_description")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SeoKeywords)
                    .HasColumnName("seo_keywords")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SeoTitle)
                    .HasColumnName("seo_title")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DtArticleComment>(entity =>
            {
                entity.ToTable("dt_article_comment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChannelId)
                    .HasColumnName("channel_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("ntext");

                entity.Property(e => e.IsLock)
                    .HasColumnName("is_lock")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsReply)
                    .HasColumnName("is_reply")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReplyContent)
                    .HasColumnName("reply_content")
                    .HasColumnType("ntext");

                entity.Property(e => e.ReplyTime)
                    .HasColumnName("reply_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserIp)
                    .HasColumnName("user_ip")
                    .HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DtChannel>(entity =>
            {
                entity.ToTable("dt_channel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsAlbums)
                    .HasColumnName("is_albums")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsAttach)
                    .HasColumnName("is_attach")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsSpec)
                    .HasColumnName("is_spec")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.DtChannel)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_DT_CHANN_REFERENCE_DT_CHANN");
            });

            modelBuilder.Entity<DtChannelField>(entity =>
            {
                entity.ToTable("dt_channel_field");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChannelId).HasColumnName("channel_id");

                entity.Property(e => e.FieldId).HasColumnName("field_id");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.DtChannelField)
                    .HasForeignKey(d => d.ChannelId)
                    .HasConstraintName("FK_DT_CHANN_REFERENCE_DT_CHANN_FIELD");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.DtChannelField)
                    .HasForeignKey(d => d.FieldId)
                    .HasConstraintName("FK_DT_CHANN_REFERENCE_DT_ARTIC");
            });

            modelBuilder.Entity<DtChannelSite>(entity =>
            {
                entity.ToTable("dt_channel_site");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.BuildPath)
                    .HasColumnName("build_path")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(255);

                entity.Property(e => e.Copyright)
                    .HasColumnName("copyright")
                    .HasColumnType("text");

                entity.Property(e => e.Crod)
                    .HasColumnName("crod")
                    .HasMaxLength(100);

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(30);

                entity.Property(e => e.IsDefault)
                    .HasColumnName("is_default")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.SeoDescription)
                    .HasColumnName("seo_description")
                    .HasMaxLength(500);

                entity.Property(e => e.SeoKeyword)
                    .HasColumnName("seo_keyword")
                    .HasMaxLength(255);

                entity.Property(e => e.SeoTitle)
                    .HasColumnName("seo_title")
                    .HasMaxLength(255);

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(30);

                entity.Property(e => e.TempletPath)
                    .HasColumnName("templet_path")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DtExpress>(entity =>
            {
                entity.ToTable("dt_express");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ExpressCode)
                    .HasColumnName("express_code")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExpressFee)
                    .HasColumnName("express_fee")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsLock)
                    .HasColumnName("is_lock")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DtFeedback>(entity =>
            {
                entity.ToTable("dt_feedback");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("ntext");

                entity.Property(e => e.IsLock)
                    .HasColumnName("is_lock")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReplyContent)
                    .HasColumnName("reply_content")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ReplyTime)
                    .HasColumnName("reply_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.SitePath)
                    .HasColumnName("site_path")
                    .HasMaxLength(100);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.UserEmail)
                    .HasColumnName("user_email")
                    .HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(50);

                entity.Property(e => e.UserQq)
                    .HasColumnName("user_qq")
                    .HasMaxLength(30);

                entity.Property(e => e.UserTel)
                    .HasColumnName("user_tel")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<DtLink>(entity =>
            {
                entity.ToTable("dt_link");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("img_url")
                    .HasMaxLength(255);

                entity.Property(e => e.IsImage)
                    .HasColumnName("is_image")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsLock).HasColumnName("is_lock");

                entity.Property(e => e.IsRed)
                    .HasColumnName("is_red")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SitePath)
                    .HasColumnName("site_path")
                    .HasMaxLength(100);

                entity.Property(e => e.SiteUrl)
                    .HasColumnName("site_url")
                    .HasMaxLength(255);

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(50);

                entity.Property(e => e.UserTel)
                    .HasColumnName("user_tel")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DtMailTemplate>(entity =>
            {
                entity.ToTable("dt_mail_template");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CallIndex)
                    .HasColumnName("call_index")
                    .HasMaxLength(50);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("ntext");

                entity.Property(e => e.IsSys)
                    .HasColumnName("is_sys")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaillTitle)
                    .HasColumnName("maill_title")
                    .HasMaxLength(100);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DtManager>(entity =>
            {
                entity.ToTable("dt_manager");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsLock)
                    .HasColumnName("is_lock")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(100);

                entity.Property(e => e.RealName)
                    .HasColumnName("real_name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.RoleType)
                    .HasColumnName("role_type")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.Salt)
                    .HasColumnName("salt")
                    .HasMaxLength(20);

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.DtManager)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_DT_MANAG_REFERENCE_DT_MANAG");
            });

            modelBuilder.Entity<DtManagerLog>(entity =>
            {
                entity.ToTable("dt_manager_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionType)
                    .HasColumnName("action_type")
                    .HasMaxLength(100);

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasColumnName("user_ip")
                    .HasMaxLength(30);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DtManagerRole>(entity =>
            {
                entity.ToTable("dt_manager_role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsSys)
                    .HasColumnName("is_sys")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RoleName)
                    .HasColumnName("role_name")
                    .HasMaxLength(100);

                entity.Property(e => e.RoleType).HasColumnName("role_type");
            });

            modelBuilder.Entity<DtManagerRoleValue>(entity =>
            {
                entity.ToTable("dt_manager_role_value");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionType)
                    .HasColumnName("action_type")
                    .HasMaxLength(50);

                entity.Property(e => e.NavName)
                    .HasColumnName("nav_name")
                    .HasMaxLength(100);

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.DtManagerRoleValue)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_DT_MANAG_REFERENCE_DT_MANAG_ROLE_VALUE");
            });

            modelBuilder.Entity<DtNavigation>(entity =>
            {
                entity.ToTable("dt_navigation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionType)
                    .HasColumnName("action_type")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ChannelId)
                    .HasColumnName("channel_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IconUrl)
                    .HasColumnName("icon_url")
                    .HasMaxLength(255);

                entity.Property(e => e.IsLock)
                    .HasColumnName("is_lock")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsSys)
                    .HasColumnName("is_sys")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("link_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NavType)
                    .HasColumnName("nav_type")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.SubTitle)
                    .HasColumnName("sub_title")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DtOrderGoods>(entity =>
            {
                entity.ToTable("dt_order_goods");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArticleId).HasColumnName("article_id");

                entity.Property(e => e.GoodsNo)
                    .HasColumnName("goods_no")
                    .HasMaxLength(50);

                entity.Property(e => e.GoodsPrice)
                    .HasColumnName("goods_price")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GoodsTitle)
                    .HasColumnName("goods_title")
                    .HasMaxLength(100);

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("img_url")
                    .HasMaxLength(255);

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RealPrice)
                    .HasColumnName("real_price")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SpecText)
                    .HasColumnName("spec_text")
                    .HasColumnType("text");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DtOrderGoods)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_DT_ORDER_REFERENCE_DT_ORDER");
            });

            modelBuilder.Entity<DtOrders>(entity =>
            {
                entity.ToTable("dt_orders");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AcceptName)
                    .HasColumnName("accept_name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CompleteTime)
                    .HasColumnName("complete_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ConfirmTime)
                    .HasColumnName("confirm_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExpressFee)
                    .HasColumnName("express_fee")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExpressId)
                    .HasColumnName("express_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExpressNo)
                    .HasColumnName("express_no")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExpressStatus)
                    .HasColumnName("express_status")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExpressTime)
                    .HasColumnName("express_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceTaxes)
                    .HasColumnName("invoice_taxes")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InvoiceTitle)
                    .HasColumnName("invoice_title")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.IsInvoice)
                    .HasColumnName("is_invoice")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OrderAmount)
                    .HasColumnName("order_amount")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PayableAmount)
                    .HasColumnName("payable_amount")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PaymentFee)
                    .HasColumnName("payment_fee")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PaymentStatus)
                    .HasColumnName("payment_status")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PaymentTime)
                    .HasColumnName("payment_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PostCode)
                    .HasColumnName("post_code")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RealAmount)
                    .HasColumnName("real_amount")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Telphone)
                    .HasColumnName("telphone")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TradeNo)
                    .HasColumnName("trade_no")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DtPayment>(entity =>
            {
                entity.ToTable("dt_payment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApiPath)
                    .HasColumnName("api_path")
                    .HasMaxLength(100);

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("img_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsLock)
                    .HasColumnName("is_lock")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PoundageAmount)
                    .HasColumnName("poundage_amount")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PoundageType)
                    .HasColumnName("poundage_type")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500);

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<DtSmsTemplate>(entity =>
            {
                entity.ToTable("dt_sms_template");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CallIndex)
                    .HasColumnName("call_index")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsSys)
                    .HasColumnName("is_sys")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DtUserAmountLog>(entity =>
            {
                entity.ToTable("dt_user_amount_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DtUserAttachLog>(entity =>
            {
                entity.ToTable("dt_user_attach_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.AttachId).HasColumnName("attach_id");

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DtUserCode>(entity =>
            {
                entity.ToTable("dt_user_code");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EffTime)
                    .HasColumnName("eff_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StrCode)
                    .HasColumnName("str_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(20);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasColumnName("user_ip")
                    .HasMaxLength(20);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DtUserGroupPrice>(entity =>
            {
                entity.ToTable("dt_user_group_price");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DtUserGroups>(entity =>
            {
                entity.ToTable("dt_user_groups");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDefault)
                    .HasColumnName("is_default")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsLock)
                    .HasColumnName("is_lock")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsUpgrade)
                    .HasColumnName("is_upgrade")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UpgradeExp)
                    .HasColumnName("upgrade_exp")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DtUserLoginLog>(entity =>
            {
                entity.ToTable("dt_user_login_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginIp)
                    .HasColumnName("login_ip")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LoginTime)
                    .HasColumnName("login_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DtUserMessage>(entity =>
            {
                entity.ToTable("dt_user_message");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AcceptUserName)
                    .HasColumnName("accept_user_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("ntext");

                entity.Property(e => e.IsRead)
                    .HasColumnName("is_read")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PostTime)
                    .HasColumnName("post_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.PostUserName)
                    .HasColumnName("post_user_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ReadTime)
                    .HasColumnName("read_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<DtUserOauth>(entity =>
            {
                entity.ToTable("dt_user_oauth");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.OauthAccessToken)
                    .HasColumnName("oauth_access_token")
                    .HasMaxLength(500);

                entity.Property(e => e.OauthName)
                    .IsRequired()
                    .HasColumnName("oauth_name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OauthOpenid)
                    .HasColumnName("oauth_openid")
                    .HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DtUserOauthApp>(entity =>
            {
                entity.ToTable("dt_user_oauth_app");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApiPath)
                    .HasColumnName("api_path")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AppId)
                    .HasColumnName("app_id")
                    .HasMaxLength(100);

                entity.Property(e => e.AppKey)
                    .HasColumnName("app_key")
                    .HasMaxLength(500);

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("img_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsLock)
                    .HasColumnName("is_lock")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DtUserPointLog>(entity =>
            {
                entity.ToTable("dt_user_point_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<DtUserRecharge>(entity =>
            {
                entity.ToTable("dt_user_recharge");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CompleteTime)
                    .HasColumnName("complete_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentId).HasColumnName("payment_id");

                entity.Property(e => e.RechargeNo)
                    .HasColumnName("recharge_no")
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DtUsers>(entity =>
            {
                entity.ToTable("dt_users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Exp)
                    .HasColumnName("exp")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Msn)
                    .HasColumnName("msn")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NickName)
                    .HasColumnName("nick_name")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(100);

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Qq)
                    .HasColumnName("qq")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RegIp)
                    .HasColumnName("reg_ip")
                    .HasMaxLength(20);

                entity.Property(e => e.RegTime)
                    .HasColumnName("reg_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Salt)
                    .HasColumnName("salt")
                    .HasMaxLength(20);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Telphone)
                    .HasColumnName("telphone")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(100);
            });
        }
    }
}