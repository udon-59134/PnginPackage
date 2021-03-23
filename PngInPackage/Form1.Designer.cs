namespace PngInPackage
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.PngRefButton = new System.Windows.Forms.Button();
            this.FileNameLabel1 = new System.Windows.Forms.Label();
            this.SelectPngFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectAllFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileNameLabel2 = new System.Windows.Forms.Label();
            this.FileRefButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.outputFileNameText = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.バージョン情報AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.埋め込み対象となる画像を選択します。";
            // 
            // PngRefButton
            // 
            this.PngRefButton.Location = new System.Drawing.Point(14, 39);
            this.PngRefButton.Name = "PngRefButton";
            this.PngRefButton.Size = new System.Drawing.Size(75, 23);
            this.PngRefButton.TabIndex = 1;
            this.PngRefButton.Text = "参照";
            this.PngRefButton.UseVisualStyleBackColor = true;
            this.PngRefButton.Click += new System.EventHandler(this.PngRefButton_Click);
            // 
            // FileNameLabel1
            // 
            this.FileNameLabel1.AutoSize = true;
            this.FileNameLabel1.Location = new System.Drawing.Point(93, 44);
            this.FileNameLabel1.Name = "FileNameLabel1";
            this.FileNameLabel1.Size = new System.Drawing.Size(123, 12);
            this.FileNameLabel1.TabIndex = 2;
            this.FileNameLabel1.Text = "ファイルを選択してください";
            // 
            // SelectPngFileDialog
            // 
            this.SelectPngFileDialog.Filter = "画像ファイル(*.png,*.PNG)|*.png;*.PNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "2.埋め込む対象のデータを選択します。";
            // 
            // SelectAllFileDialog
            // 
            this.SelectAllFileDialog.Filter = "すべてのファイル(*.*)|*.*";
            // 
            // FileNameLabel2
            // 
            this.FileNameLabel2.AutoSize = true;
            this.FileNameLabel2.Location = new System.Drawing.Point(95, 85);
            this.FileNameLabel2.Name = "FileNameLabel2";
            this.FileNameLabel2.Size = new System.Drawing.Size(123, 12);
            this.FileNameLabel2.TabIndex = 5;
            this.FileNameLabel2.Text = "ファイルを選択してください";
            // 
            // FileRefButton
            // 
            this.FileRefButton.Location = new System.Drawing.Point(14, 80);
            this.FileRefButton.Name = "FileRefButton";
            this.FileRefButton.Size = new System.Drawing.Size(75, 23);
            this.FileRefButton.TabIndex = 4;
            this.FileRefButton.Text = "参照";
            this.FileRefButton.UseVisualStyleBackColor = true;
            this.FileRefButton.Click += new System.EventHandler(this.FileRefButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "3.出力するファイル名を選択します。";
            // 
            // outputFileNameText
            // 
            this.outputFileNameText.Location = new System.Drawing.Point(14, 121);
            this.outputFileNameText.Name = "outputFileNameText";
            this.outputFileNameText.Size = new System.Drawing.Size(736, 19);
            this.outputFileNameText.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 228);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(741, 210);
            this.textBox2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "4.実行ボタンを押します。";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ExecuteButton.Location = new System.Drawing.Point(12, 158);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(738, 64);
            this.ExecuteButton.TabIndex = 10;
            this.ExecuteButton.Text = "実行";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報AToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // バージョン情報AToolStripMenuItem
            // 
            this.バージョン情報AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報ToolStripMenuItem});
            this.バージョン情報AToolStripMenuItem.Name = "バージョン情報AToolStripMenuItem";
            this.バージョン情報AToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.バージョン情報AToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // バージョン情報ToolStripMenuItem
            // 
            this.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            this.バージョン情報ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.バージョン情報ToolStripMenuItem.Text = "バージョン情報(&A)";
            this.バージョン情報ToolStripMenuItem.Click += new System.EventHandler(this.バージョン情報ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.outputFileNameText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FileNameLabel2);
            this.Controls.Add(this.FileRefButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FileNameLabel1);
            this.Controls.Add(this.PngRefButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Png埋め込みツール";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PngRefButton;
        private System.Windows.Forms.Label FileNameLabel1;
        private System.Windows.Forms.OpenFileDialog SelectPngFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog SelectAllFileDialog;
        private System.Windows.Forms.Label FileNameLabel2;
        private System.Windows.Forms.Button FileRefButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox outputFileNameText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem;
    }
}

