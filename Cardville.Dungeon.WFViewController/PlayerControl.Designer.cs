
namespace Cardville.Dungeon.WFViewController
{
    partial class PlayerControl
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
            metroPanel1.Click += new System.EventHandler(this.metroPanel1_Click_1);
            // 
            // powerLabel
            // 
            this.powerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.powerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
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
            this.nameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
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
            this.rarityColorBorder.TabIndex = 1;
            this.rarityColorBorder.UseCustomBackColor = true;
            this.rarityColorBorder.VerticalScrollbarBarColor = true;
            this.rarityColorBorder.VerticalScrollbarHighlightOnWheel = false;
            this.rarityColorBorder.VerticalScrollbarSize = 10;
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rarityColorBorder);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(236, 369);
            metroPanel1.ResumeLayout(false);
            this.rarityColorBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroPanel rarityColorBorder;
        private MetroFramework.Controls.MetroLabel powerLabel;
    }
}
