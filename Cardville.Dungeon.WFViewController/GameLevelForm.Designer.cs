
namespace Cardville.Dungeon.WFViewController
{
    partial class GameLevelForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dungeonPanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // dungeonPanel
            // 
            this.dungeonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dungeonPanel.HorizontalScrollbarBarColor = true;
            this.dungeonPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.dungeonPanel.HorizontalScrollbarSize = 10;
            this.dungeonPanel.Location = new System.Drawing.Point(23, 63);
            this.dungeonPanel.Name = "dungeonPanel";
            this.dungeonPanel.Size = new System.Drawing.Size(674, 874);
            this.dungeonPanel.TabIndex = 1;
            this.dungeonPanel.VerticalScrollbarBarColor = true;
            this.dungeonPanel.VerticalScrollbarHighlightOnWheel = false;
            this.dungeonPanel.VerticalScrollbarSize = 10;
            // 
            // GameLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 960);
            this.Controls.Add(this.dungeonPanel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "GameLevelForm";
            this.Text = "Cardville Dungeon pre-alpha";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel dungeonPanel;
    }
}

