namespace Shipping_Company
{
    partial class employee_add_client
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.employee_add_client_ssn = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employee_add_client_ln = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employee_add_client_fn = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.employee_add_client_add_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.employee_error_label = new System.Windows.Forms.Label();
            this.employee_successful_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "SSN";
            // 
            // employee_add_client_ssn
            // 
            this.employee_add_client_ssn.Location = new System.Drawing.Point(175, 125);
            this.employee_add_client_ssn.Name = "employee_add_client_ssn";
            this.employee_add_client_ssn.Size = new System.Drawing.Size(315, 35);
            this.employee_add_client_ssn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.employee_add_client_ssn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.employee_add_client_ssn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.employee_add_client_ssn.StateCommon.Border.Rounding = 20;
            this.employee_add_client_ssn.StateCommon.Border.Width = 1;
            this.employee_add_client_ssn.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.employee_add_client_ssn.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_add_client_ssn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.employee_add_client_ssn.TabIndex = 15;
            this.employee_add_client_ssn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employee_add_client_ssn_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Last Name";
            // 
            // employee_add_client_ln
            // 
            this.employee_add_client_ln.Location = new System.Drawing.Point(531, 58);
            this.employee_add_client_ln.Name = "employee_add_client_ln";
            this.employee_add_client_ln.Size = new System.Drawing.Size(193, 35);
            this.employee_add_client_ln.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.employee_add_client_ln.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.employee_add_client_ln.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.employee_add_client_ln.StateCommon.Border.Rounding = 20;
            this.employee_add_client_ln.StateCommon.Border.Width = 1;
            this.employee_add_client_ln.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.employee_add_client_ln.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_add_client_ln.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.employee_add_client_ln.TabIndex = 13;
            this.employee_add_client_ln.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employee_add_client_ln_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Name";
            // 
            // employee_add_client_fn
            // 
            this.employee_add_client_fn.Location = new System.Drawing.Point(175, 58);
            this.employee_add_client_fn.Name = "employee_add_client_fn";
            this.employee_add_client_fn.Size = new System.Drawing.Size(193, 35);
            this.employee_add_client_fn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.employee_add_client_fn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.employee_add_client_fn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.employee_add_client_fn.StateCommon.Border.Rounding = 20;
            this.employee_add_client_fn.StateCommon.Border.Width = 1;
            this.employee_add_client_fn.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.employee_add_client_fn.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_add_client_fn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.employee_add_client_fn.TabIndex = 11;
            this.employee_add_client_fn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employee_add_client_fn_KeyPress);
            // 
            // employee_add_client_add_btn
            // 
            this.employee_add_client_add_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.employee_add_client_add_btn.Location = new System.Drawing.Point(200, 297);
            this.employee_add_client_add_btn.Name = "employee_add_client_add_btn";
            this.employee_add_client_add_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(250)))), ((int)(((byte)(138)))));
            this.employee_add_client_add_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(227)))), ((int)(((byte)(148)))));
            this.employee_add_client_add_btn.OverrideDefault.Back.ColorAngle = 45F;
            this.employee_add_client_add_btn.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.employee_add_client_add_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(250)))), ((int)(((byte)(138)))));
            this.employee_add_client_add_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(227)))), ((int)(((byte)(148)))));
            this.employee_add_client_add_btn.OverrideDefault.Border.ColorAngle = 45F;
            this.employee_add_client_add_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.employee_add_client_add_btn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.employee_add_client_add_btn.OverrideDefault.Border.Rounding = 20;
            this.employee_add_client_add_btn.OverrideDefault.Border.Width = 1;
            this.employee_add_client_add_btn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.employee_add_client_add_btn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.employee_add_client_add_btn.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_add_client_add_btn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.employee_add_client_add_btn.Size = new System.Drawing.Size(119, 56);
            this.employee_add_client_add_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(250)))), ((int)(((byte)(138)))));
            this.employee_add_client_add_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(227)))), ((int)(((byte)(148)))));
            this.employee_add_client_add_btn.StateCommon.Back.ColorAngle = 45F;
            this.employee_add_client_add_btn.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.employee_add_client_add_btn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(250)))), ((int)(((byte)(138)))));
            this.employee_add_client_add_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(227)))), ((int)(((byte)(148)))));
            this.employee_add_client_add_btn.StateCommon.Border.ColorAngle = 45F;
            this.employee_add_client_add_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.employee_add_client_add_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.employee_add_client_add_btn.StateCommon.Border.Rounding = 20;
            this.employee_add_client_add_btn.StateCommon.Border.Width = 1;
            this.employee_add_client_add_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.employee_add_client_add_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.employee_add_client_add_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_add_client_add_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(250)))), ((int)(((byte)(138)))));
            this.employee_add_client_add_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(227)))), ((int)(((byte)(148)))));
            this.employee_add_client_add_btn.StatePressed.Back.ColorAngle = 135F;
            this.employee_add_client_add_btn.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.employee_add_client_add_btn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(250)))), ((int)(((byte)(138)))));
            this.employee_add_client_add_btn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(227)))), ((int)(((byte)(148)))));
            this.employee_add_client_add_btn.StatePressed.Border.ColorAngle = 135F;
            this.employee_add_client_add_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.employee_add_client_add_btn.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.employee_add_client_add_btn.StatePressed.Border.Rounding = 20;
            this.employee_add_client_add_btn.StatePressed.Border.Width = 1;
            this.employee_add_client_add_btn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.employee_add_client_add_btn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.employee_add_client_add_btn.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_add_client_add_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(250)))), ((int)(((byte)(138)))));
            this.employee_add_client_add_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(227)))), ((int)(((byte)(148)))));
            this.employee_add_client_add_btn.StateTracking.Back.ColorAngle = 45F;
            this.employee_add_client_add_btn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.employee_add_client_add_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(250)))), ((int)(((byte)(138)))));
            this.employee_add_client_add_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(227)))), ((int)(((byte)(148)))));
            this.employee_add_client_add_btn.StateTracking.Border.ColorAngle = 45F;
            this.employee_add_client_add_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.employee_add_client_add_btn.StateTracking.Border.Rounding = 20;
            this.employee_add_client_add_btn.StateTracking.Border.Width = 1;
            this.employee_add_client_add_btn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.employee_add_client_add_btn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.employee_add_client_add_btn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_add_client_add_btn.TabIndex = 19;
            this.employee_add_client_add_btn.Values.Text = "Add";
            this.employee_add_client_add_btn.Click += new System.EventHandler(this.employee_add_client_add_btn_Click);
            // 
            // employee_error_label
            // 
            this.employee_error_label.AutoSize = true;
            this.employee_error_label.ForeColor = System.Drawing.Color.Red;
            this.employee_error_label.Location = new System.Drawing.Point(184, 366);
            this.employee_error_label.Name = "employee_error_label";
            this.employee_error_label.Size = new System.Drawing.Size(152, 16);
            this.employee_error_label.TabIndex = 20;
            this.employee_error_label.Text = "Data entered is incorrect";
            this.employee_error_label.UseMnemonic = false;
            this.employee_error_label.Visible = false;
            // 
            // employee_successful_label
            // 
            this.employee_successful_label.AutoSize = true;
            this.employee_successful_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.employee_successful_label.Location = new System.Drawing.Point(184, 366);
            this.employee_successful_label.Name = "employee_successful_label";
            this.employee_successful_label.Size = new System.Drawing.Size(155, 16);
            this.employee_successful_label.TabIndex = 21;
            this.employee_successful_label.Text = "Data added successfully";
            this.employee_successful_label.UseMnemonic = false;
            this.employee_successful_label.Visible = false;
            // 
            // employee_add_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employee_successful_label);
            this.Controls.Add(this.employee_error_label);
            this.Controls.Add(this.employee_add_client_add_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.employee_add_client_ssn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employee_add_client_ln);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employee_add_client_fn);
            this.Name = "employee_add_client";
            this.Size = new System.Drawing.Size(800, 456);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox employee_add_client_ssn;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox employee_add_client_ln;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox employee_add_client_fn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton employee_add_client_add_btn;
        private System.Windows.Forms.Label employee_error_label;
        private System.Windows.Forms.Label employee_successful_label;
    }
}
