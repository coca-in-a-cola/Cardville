
namespace Cardville.Dungeon.WFViewController
{
    partial class CardControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            MetroFramework.Controls.MetroPanel metroPanel1;
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.typeLabel = new MetroFramework.Controls.MetroLabel();
            this.rarityLabel = new MetroFramework.Controls.MetroLabel();
            this.powerLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.rarityColorBorder = new MetroFramework.Controls.MetroPanel();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            metroPanel1.SuspendLayout();
            this.rarityColorBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            metroPanel1.BackColor = System.Drawing.Color.White;
            metroPanel1.Controls.Add(this.descriptionLabel);
            metroPanel1.Controls.Add(this.typeLabel);
            metroPanel1.Controls.Add(this.rarityLabel);
            metroPanel1.Controls.Add(this.powerLabel);
            metroPanel1.Controls.Add(this.nameLabel);
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new System.Drawing.Point(3, 3);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new System.Drawing.Size(224, 357);
            metroPanel1.TabIndex = 2;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            metroPanel1.Click += new System.EventHandler(this.metroPanel1_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.descriptionLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 98);
            this.descriptionLabel.MaximumSize = new System.Drawing.Size(218, 222);
            this.descriptionLabel.MinimumSize = new System.Drawing.Size(218, 49);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(218, 49);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Приходит, значит, мужик к батюшке, \\n  и говорит,мол, можно покаятся.\r\nБатюшка ем" +
    "у: конечно. Он начинает\r\n";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.typeLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.typeLabel.Location = new System.Drawing.Point(112, 320);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(112, 37);
            this.typeLabel.TabIndex = 6;
            this.typeLabel.Text = "metroLabel1";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // rarityLabel
            // 
            this.rarityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rarityLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.rarityLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.rarityLabel.Location = new System.Drawing.Point(0, 320);
            this.rarityLabel.Name = "rarityLabel";
            this.rarityLabel.Size = new System.Drawing.Size(112, 37);
            this.rarityLabel.TabIndex = 5;
            this.rarityLabel.Text = "metroLabel1";
            this.rarityLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // powerLabel
            // 
            this.powerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.powerLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.powerLabel.Location = new System.Drawing.Point(3, 51);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(218, 47);
            this.powerLabel.TabIndex = 3;
            this.powerLabel.Text = "metroLabel1";
            this.powerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(218, 51);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "metroLabel1";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rarityColorBorder
            // 
            this.rarityColorBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rarityColorBorder.BackColor = System.Drawing.Color.Red;
            this.rarityColorBorder.Controls.Add(metroPanel1);
            this.rarityColorBorder.HorizontalScrollbarBarColor = true;
            this.rarityColorBorder.HorizontalScrollbarHighlightOnWheel = false;
            this.rarityColorBorder.HorizontalScrollbarSize = 10;
            this.rarityColorBorder.Location = new System.Drawing.Point(3, 3);
            this.rarityColorBorder.Name = "rarityColorBorder";
            this.rarityColorBorder.Size = new System.Drawing.Size(230, 363);
            this.rarityColorBorder.TabIndex = 0;
            this.rarityColorBorder.UseCustomBackColor = true;
            this.rarityColorBorder.VerticalScrollbarBarColor = true;
            this.rarityColorBorder.VerticalScrollbarHighlightOnWheel = false;
            this.rarityColorBorder.VerticalScrollbarSize = 10;
            // 
            // CardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rarityColorBorder);
            this.Name = "CardControl";
            this.Size = new System.Drawing.Size(236, 369);
            metroPanel1.ResumeLayout(false);
            this.rarityColorBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel rarityColorBorder;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel typeLabel;
        private MetroFramework.Controls.MetroLabel rarityLabel;
        private MetroFramework.Controls.MetroLabel powerLabel;
        private MetroFramework.Controls.MetroLabel descriptionLabel;
    }
}
