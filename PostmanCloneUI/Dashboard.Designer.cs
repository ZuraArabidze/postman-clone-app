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
            resultsText = new TextBox();
            callAPI = new Button();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            resultsLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Sylfaen", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formHeader.Location = new Point(33, 21);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(625, 89);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postman Clone APP";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Location = new Point(33, 173);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(118, 62);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API:";
            // 
            // apiText
            // 
            apiText.BorderStyle = BorderStyle.FixedSingle;
            apiText.Location = new Point(178, 170);
            apiText.Name = "apiText";
            apiText.Size = new Size(1284, 71);
            apiText.TabIndex = 2;
            apiText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // resultsText
            // 
            resultsText.BackColor = Color.White;
            resultsText.BorderStyle = BorderStyle.FixedSingle;
            resultsText.Location = new Point(33, 384);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(1579, 468);
            resultsText.TabIndex = 3;
            resultsText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            // 
            // callAPI
            // 
            callAPI.BackColor = Color.White;
            callAPI.Location = new Point(1481, 170);
            callAPI.Name = "callAPI";
            callAPI.Size = new Size(131, 74);
            callAPI.TabIndex = 4;
            callAPI.Text = "GO";
            callAPI.UseVisualStyleBackColor = false;
            callAPI.Click += callAPI_Click;
            callAPI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.White;
            statusStrip.ImageScalingSize = new Size(32, 32);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 957);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1662, 58);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "System Status";
            statusStrip.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Sylfaen", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(116, 48);
            systemStatus.Text = "Ready";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(33, 281);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(182, 62);
            resultsLabel.TabIndex = 6;
            resultsLabel.Text = "Results:";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(27F, 62F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1662, 1015);
            Controls.Add(resultsLabel);
            Controls.Add(statusStrip);
            Controls.Add(callAPI);
            Controls.Add(resultsText);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Controls.Add(formHeader);
            Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Postman Clone";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private TextBox apiText;
        private TextBox resultsText;
        private Button callAPI;
        private StatusStrip statusStrip;
        private Label resultsLabel;
        private ToolStripStatusLabel systemStatus;
    }
}
