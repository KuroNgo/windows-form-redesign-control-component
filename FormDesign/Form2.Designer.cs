namespace Basic
{
    partial class Form2
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
            panelContainer = new Panel();
            panelTitleBar = new Panel();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.Lavender;
            panelContainer.Dock = DockStyle.Bottom;
            panelContainer.Location = new Point(0, 56);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(800, 394);
            panelContainer.TabIndex = 0;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // panelTitleBar
            // 
            panelTitleBar.Dock = DockStyle.Fill;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(800, 56);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(panelTitleBar);
            Controls.Add(panelContainer);
            Name = "Form2";
            Text = "Form2";
            Activated += Form2_Activated;
            ResizeEnd += Form2_ResizeEnd;
            SizeChanged += Form2_SizeChanged;
            Paint += Form2_Paint;
            MouseDown += Form2_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private Panel panelTitleBar;
    }
}