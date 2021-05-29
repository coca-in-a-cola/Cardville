
namespace Cardville.Dungeon.WFViewController
{
    partial class DungeonControl
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.daysLabel = new MetroFramework.Controls.MetroTile();
            this.cardPanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(132, 36);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Подземелье";
            this.metroTile1.UseSelectable = true;
            // 
            // daysLabel
            // 
            this.daysLabel.ActiveControl = null;
            this.daysLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.daysLabel.Location = new System.Drawing.Point(141, 3);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(345, 36);
            this.daysLabel.TabIndex = 2;
            this.daysLabel.Text = "Дней:";
            this.daysLabel.UseSelectable = true;
            // 
            // cardPanel
            // 
            this.cardPanel.HorizontalScrollbarBarColor = true;
            this.cardPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.cardPanel.HorizontalScrollbarSize = 10;
            this.cardPanel.Location = new System.Drawing.Point(3, 45);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(547, 570);
            this.cardPanel.TabIndex = 3;
            this.cardPanel.VerticalScrollbarBarColor = true;
            this.cardPanel.VerticalScrollbarHighlightOnWheel = false;
            this.cardPanel.VerticalScrollbarSize = 10;
            // 
            // DungeonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cardPanel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.metroTile1);
            this.Name = "DungeonControl";
            this.Size = new System.Drawing.Size(720, 1280);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile daysLabel;
        private MetroFramework.Controls.MetroPanel cardPanel;
    }
}
