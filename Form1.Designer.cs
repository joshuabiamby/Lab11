namespace Lab11
{
    partial class clearbtn
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
            operand1txtbox = new TextBox();
            operand2txtbox = new TextBox();
            resultbl = new Label();
            sumbtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // operand1txtbox
            // 
            operand1txtbox.Location = new Point(12, 12);
            operand1txtbox.Name = "operand1txtbox";
            operand1txtbox.Size = new Size(100, 31);
            operand1txtbox.TabIndex = 2;
            operand1txtbox.UseWaitCursor = true;
            operand1txtbox.TextChanged += operand1txtbox_TextChanged;
            // 
            // operand2txtbox
            // 
            operand2txtbox.Location = new Point(118, 12);
            operand2txtbox.Name = "operand2txtbox";
            operand2txtbox.Size = new Size(100, 31);
            operand2txtbox.TabIndex = 3;
            // 
            // resultbl
            // 
            resultbl.AutoSize = true;
            resultbl.Location = new Point(224, 15);
            resultbl.Name = "resultbl";
            resultbl.Size = new Size(0, 25);
            resultbl.TabIndex = 4;
            resultbl.Click += label1_Click;
            // 
            // sumbtn
            // 
            sumbtn.Location = new Point(25, 45);
            sumbtn.Name = "sumbtn";
            sumbtn.Size = new Size(87, 38);
            sumbtn.TabIndex = 5;
            sumbtn.Text = "Sum";
            sumbtn.UseVisualStyleBackColor = true;
            sumbtn.Click += sumbtn_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(118, 49);
            button1.Name = "button1";
            button1.Size = new Size(81, 34);
            button1.TabIndex = 6;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // clearbtn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 94);
            Controls.Add(button1);
            Controls.Add(sumbtn);
            Controls.Add(resultbl);
            Controls.Add(operand2txtbox);
            Controls.Add(operand1txtbox);
            Name = "clearbtn";
            Text = "FYE Summator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox operand1txtbox;
        private TextBox operand2txtbox;
        private Label resultbl;
        private Button sumbtn;
        private Button button1;
    }
}
