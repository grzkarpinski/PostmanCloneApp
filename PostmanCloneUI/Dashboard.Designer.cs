namespace PostmanCloneUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formHeader = new Label();
            apiLabel = new Label();
            apiText = new TextBox();
            callApi = new Button();
            resultsText = new TextBox();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            resultLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            formHeader.Location = new Point(309, 9);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(317, 60);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postman Clone";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Location = new Point(12, 82);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(69, 41);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API:";
            apiLabel.Click += apiLabel_Click;
            // 
            // apiText
            // 
            apiText.Location = new Point(78, 82);
            apiText.Name = "apiText";
            apiText.Size = new Size(771, 47);
            apiText.TabIndex = 2;
            // 
            // callApi
            // 
            callApi.Location = new Point(855, 80);
            callApi.Name = "callApi";
            callApi.Size = new Size(95, 50);
            callApi.TabIndex = 3;
            callApi.Text = "GO";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += callApi_Click;
            // 
            // resultsText
            // 
            resultsText.BackColor = Color.White;
            resultsText.BorderStyle = BorderStyle.FixedSingle;
            resultsText.Location = new Point(12, 202);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(938, 300);
            resultsText.TabIndex = 4;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.Transparent;
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 505);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(962, 37);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(76, 31);
            systemStatus.Text = "Ready";
            systemStatus.Click += systemStatus_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(78, 141);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(118, 41);
            resultLabel.TabIndex = 6;
            resultLabel.Text = "Results:";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(962, 542);
            Controls.Add(resultLabel);
            Controls.Add(statusStrip);
            Controls.Add(resultsText);
            Controls.Add(callApi);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Postman Clone";
            Load += Dashboard_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private TextBox apiText;
        private Button callApi;
        private TextBox resultsText;
        private StatusStrip statusStrip;
        private Label resultLabel;
        private ToolStripStatusLabel systemStatus;
    }
}
