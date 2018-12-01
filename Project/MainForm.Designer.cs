namespace OpenAsApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.Website_address_Label = new System.Windows.Forms.Label();
            this.Website_address_TextBox = new System.Windows.Forms.TextBox();
            this.Shortcut_name_Label = new System.Windows.Forms.Label();
            this.Shortcut_name_TextBox = new System.Windows.Forms.TextBox();
            this.Create_shortcut_Button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Use_HTTPS_CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Website_address_Label
            // 
            this.Website_address_Label.AutoSize = true;
            this.Website_address_Label.Location = new System.Drawing.Point(12, 9);
            this.Website_address_Label.Name = "Website_address_Label";
            this.Website_address_Label.Size = new System.Drawing.Size(86, 13);
            this.Website_address_Label.TabIndex = 0;
            this.Website_address_Label.Text = "Website address";
            this.toolTip1.SetToolTip(this.Website_address_Label, "The address the shortcut will save to");
            // 
            // Website_address_TextBox
            // 
            this.Website_address_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Website_address_TextBox.Location = new System.Drawing.Point(12, 25);
            this.Website_address_TextBox.Name = "Website_address_TextBox";
            this.Website_address_TextBox.Size = new System.Drawing.Size(303, 20);
            this.Website_address_TextBox.TabIndex = 1;
            this.Website_address_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            // 
            // Shortcut_name_Label
            // 
            this.Shortcut_name_Label.AutoSize = true;
            this.Shortcut_name_Label.Location = new System.Drawing.Point(12, 48);
            this.Shortcut_name_Label.Name = "Shortcut_name_Label";
            this.Shortcut_name_Label.Size = new System.Drawing.Size(76, 13);
            this.Shortcut_name_Label.TabIndex = 2;
            this.Shortcut_name_Label.Text = "Shortcut name";
            this.toolTip1.SetToolTip(this.Shortcut_name_Label, "The name of the shortcut");
            // 
            // Shortcut_name_TextBox
            // 
            this.Shortcut_name_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Shortcut_name_TextBox.Location = new System.Drawing.Point(12, 64);
            this.Shortcut_name_TextBox.Name = "Shortcut_name_TextBox";
            this.Shortcut_name_TextBox.Size = new System.Drawing.Size(303, 20);
            this.Shortcut_name_TextBox.TabIndex = 3;
            this.Shortcut_name_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            // 
            // Create_shortcut_Button
            // 
            this.Create_shortcut_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Create_shortcut_Button.Location = new System.Drawing.Point(12, 114);
            this.Create_shortcut_Button.Name = "Create_shortcut_Button";
            this.Create_shortcut_Button.Size = new System.Drawing.Size(303, 47);
            this.Create_shortcut_Button.TabIndex = 7;
            this.Create_shortcut_Button.Text = "Create shortcut";
            this.toolTip1.SetToolTip(this.Create_shortcut_Button, "Create the shortcut");
            this.Create_shortcut_Button.UseVisualStyleBackColor = true;
            this.Create_shortcut_Button.Click += new System.EventHandler(this.Create_shortcut_Button_Click);
            // 
            // Use_HTTPS_CheckBox
            // 
            this.Use_HTTPS_CheckBox.AutoSize = true;
            this.Use_HTTPS_CheckBox.Checked = true;
            this.Use_HTTPS_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Use_HTTPS_CheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Use_HTTPS_CheckBox.Location = new System.Drawing.Point(12, 90);
            this.Use_HTTPS_CheckBox.Name = "Use_HTTPS_CheckBox";
            this.Use_HTTPS_CheckBox.Size = new System.Drawing.Size(160, 17);
            this.Use_HTTPS_CheckBox.TabIndex = 8;
            this.Use_HTTPS_CheckBox.Text = "Use HTTPS (recommended)";
            this.toolTip1.SetToolTip(this.Use_HTTPS_CheckBox, "Uses HTTPS in the app\'s URL. It is reccommended you only uncheck this if the app " +
        "doesn\'t work otherwise.");
            this.Use_HTTPS_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 173);
            this.Controls.Add(this.Use_HTTPS_CheckBox);
            this.Controls.Add(this.Create_shortcut_Button);
            this.Controls.Add(this.Shortcut_name_TextBox);
            this.Controls.Add(this.Shortcut_name_Label);
            this.Controls.Add(this.Website_address_TextBox);
            this.Controls.Add(this.Website_address_Label);
            this.Name = "Form1";
            this.Text = "Open As App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Website_address_Label;
        private System.Windows.Forms.TextBox Website_address_TextBox;
        private System.Windows.Forms.Label Shortcut_name_Label;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox Shortcut_name_TextBox;
        private System.Windows.Forms.Button Create_shortcut_Button;
        private System.Windows.Forms.CheckBox Use_HTTPS_CheckBox;
    }
}

