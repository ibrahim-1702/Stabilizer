namespace Stabilizer
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabOutput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabState = new System.Windows.Forms.Label();
            this.B1Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "STABILIZER";
            // 
            // TBInput
            // 
            this.TBInput.Location = new System.Drawing.Point(166, 87);
            this.TBInput.Name = "TBInput";
            this.TBInput.Size = new System.Drawing.Size(100, 20);
            this.TBInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(129, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(73, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Input (volts) :-";
            // 
            // LabOutput
            // 
            this.LabOutput.AutoSize = true;
            this.LabOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabOutput.Location = new System.Drawing.Point(200, 169);
            this.LabOutput.Name = "LabOutput";
            this.LabOutput.Size = new System.Drawing.Size(19, 13);
            this.LabOutput.TabIndex = 4;
            this.LabOutput.Text = "----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(132, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Status :-";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // LabState
            // 
            this.LabState.AutoSize = true;
            this.LabState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabState.Location = new System.Drawing.Point(201, 210);
            this.LabState.Name = "LabState";
            this.LabState.Size = new System.Drawing.Size(23, 15);
            this.LabState.TabIndex = 6;
            this.LabState.Text = "----";
            // 
            // B1Enter
            // 
            this.B1Enter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B1Enter.Location = new System.Drawing.Point(272, 83);
            this.B1Enter.Name = "B1Enter";
            this.B1Enter.Size = new System.Drawing.Size(75, 26);
            this.B1Enter.TabIndex = 7;
            this.B1Enter.Text = "ENTER";
            this.B1Enter.UseVisualStyleBackColor = true;
            this.B1Enter.Click += new System.EventHandler(this.B1Enter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(480, 287);
            this.Controls.Add(this.B1Enter);
            this.Controls.Add(this.LabState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBInput);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Stabilizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabState;
        private System.Windows.Forms.Button B1Enter;
    }
}

