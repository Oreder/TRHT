namespace ModelProject.Navigation
{
    partial class Graph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.confirmBtn = new System.Windows.Forms.Button();
            this.selector = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // confirmBtn
            // 
            this.confirmBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.confirmBtn.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(0, 151);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(250, 40);
            this.confirmBtn.TabIndex = 7;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // selector
            // 
            this.selector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selector.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selector.FormattingEnabled = true;
            this.selector.Items.AddRange(new object[] {
            "Up",
            "U (exact solution)",
            "U (scheme solution)",
            "U (Schuster-Schwarzschild)",
            "mScheme"});
            this.selector.Location = new System.Drawing.Point(0, 0);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(250, 151);
            this.selector.TabIndex = 8;
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 191);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.confirmBtn);
            this.Name = "Graph";
            this.Text = "Graph";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.CheckedListBox selector;
    }
}