namespace Shipping_Company
{
    partial class supervisor_update_price
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
            this.supervisor_update_price_truck_type = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.supervisor_update_price_unsuccessful_label = new System.Windows.Forms.Label();
            this.supervisor_update_price_successful_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.supervisor_update_price_new_price = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.supervisor_update_list_update_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label4 = new System.Windows.Forms.Label();
            this.MinWeight_TextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MaxWeight_TextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supervisor_update_price_truck_type)).BeginInit();
            this.SuspendLayout();
            // 
            // supervisor_update_price_truck_type
            // 
            this.supervisor_update_price_truck_type.DropDownWidth = 181;
            this.supervisor_update_price_truck_type.Items.AddRange(new object[] {
            "Normal",
            "Special",
            "VIP"});
            this.supervisor_update_price_truck_type.Location = new System.Drawing.Point(209, 172);
            this.supervisor_update_price_truck_type.Name = "supervisor_update_price_truck_type";
            this.supervisor_update_price_truck_type.Size = new System.Drawing.Size(193, 38);
            this.supervisor_update_price_truck_type.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.supervisor_update_price_truck_type.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.supervisor_update_price_truck_type.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.supervisor_update_price_truck_type.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.supervisor_update_price_truck_type.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.supervisor_update_price_truck_type.StateCommon.ComboBox.Border.Rounding = 20;
            this.supervisor_update_price_truck_type.StateCommon.ComboBox.Border.Width = 1;
            this.supervisor_update_price_truck_type.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.supervisor_update_price_truck_type.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisor_update_price_truck_type.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.supervisor_update_price_truck_type.TabIndex = 50;
            this.supervisor_update_price_truck_type.SelectedIndexChanged += new System.EventHandler(this.supervisor_update_price_truck_type_SelectedIndexChanged);
            // 
            // supervisor_update_price_unsuccessful_label
            // 
            this.supervisor_update_price_unsuccessful_label.AutoSize = true;
            this.supervisor_update_price_unsuccessful_label.Enabled = false;
            this.supervisor_update_price_unsuccessful_label.ForeColor = System.Drawing.Color.Red;
            this.supervisor_update_price_unsuccessful_label.Location = new System.Drawing.Point(558, 366);
            this.supervisor_update_price_unsuccessful_label.Name = "supervisor_update_price_unsuccessful_label";
            this.supervisor_update_price_unsuccessful_label.Size = new System.Drawing.Size(144, 20);
            this.supervisor_update_price_unsuccessful_label.TabIndex = 49;
            this.supervisor_update_price_unsuccessful_label.Text = "unsuccessfully updated";
            this.supervisor_update_price_unsuccessful_label.UseCompatibleTextRendering = true;
            this.supervisor_update_price_unsuccessful_label.Visible = false;
            // 
            // supervisor_update_price_successful_label
            // 
            this.supervisor_update_price_successful_label.AutoSize = true;
            this.supervisor_update_price_successful_label.Enabled = false;
            this.supervisor_update_price_successful_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.supervisor_update_price_successful_label.Location = new System.Drawing.Point(562, 367);
            this.supervisor_update_price_successful_label.Name = "supervisor_update_price_successful_label";
            this.supervisor_update_price_successful_label.Size = new System.Drawing.Size(133, 16);
            this.supervisor_update_price_successful_label.TabIndex = 48;
            this.supervisor_update_price_successful_label.Text = "successfully updated";
            this.supervisor_update_price_successful_label.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Truck Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "New Price (EGP)";
            // 
            // supervisor_update_price_new_price
            // 
            this.supervisor_update_price_new_price.Location = new System.Drawing.Point(209, 241);
            this.supervisor_update_price_new_price.Name = "supervisor_update_price_new_price";
            this.supervisor_update_price_new_price.Size = new System.Drawing.Size(193, 35);
            this.supervisor_update_price_new_price.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.supervisor_update_price_new_price.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.supervisor_update_price_new_price.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.supervisor_update_price_new_price.StateCommon.Border.Rounding = 20;
            this.supervisor_update_price_new_price.StateCommon.Border.Width = 1;
            this.supervisor_update_price_new_price.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.supervisor_update_price_new_price.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisor_update_price_new_price.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.supervisor_update_price_new_price.TabIndex = 44;
            this.supervisor_update_price_new_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.supervisor_update_price_new_price_KeyPress);
            // 
            // supervisor_update_list_update_btn
            // 
            this.supervisor_update_list_update_btn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.supervisor_update_list_update_btn.Location = new System.Drawing.Point(569, 302);
            this.supervisor_update_list_update_btn.Name = "supervisor_update_list_update_btn";
            this.supervisor_update_list_update_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(250)))), ((int)(((byte)(138)))));
            this.supervisor_update_list_update_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(227)))), ((int)(((byte)(148)))));
            this.supervisor_update_list_update_btn.OverrideDefault.Back.ColorAngle = 45F;
            this.supervisor_update_list_update_btn.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.supervisor_update_list_update_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(250)))), ((int)(((byte)(138)))));
            this.supervisor_update_list_update_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(227)))), ((int)(((byte)(148)))));
            this.supervisor_update_list_update_btn.OverrideDefault.Border.ColorAngle = 45F;
            this.supervisor_update_list_update_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.supervisor_update_list_update_btn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.supervisor_update_list_update_btn.OverrideDefault.Border.Rounding = 20;
            this.supervisor_update_list_update_btn.OverrideDefault.Border.Width = 1;
            this.supervisor_update_list_update_btn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.supervisor_update_list_update_btn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.supervisor_update_list_update_btn.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisor_update_list_update_btn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.supervisor_update_list_update_btn.Size = new System.Drawing.Size(119, 56);
            this.supervisor_update_list_update_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(250)))), ((int)(((byte)(138)))));
            this.supervisor_update_list_update_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(227)))), ((int)(((byte)(148)))));
            this.supervisor_update_list_update_btn.StateCommon.Back.ColorAngle = 45F;
            this.supervisor_update_list_update_btn.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.supervisor_update_list_update_btn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(250)))), ((int)(((byte)(138)))));
            this.supervisor_update_list_update_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(227)))), ((int)(((byte)(148)))));
            this.supervisor_update_list_update_btn.StateCommon.Border.ColorAngle = 45F;
            this.supervisor_update_list_update_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.supervisor_update_list_update_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.supervisor_update_list_update_btn.StateCommon.Border.Rounding = 20;
            this.supervisor_update_list_update_btn.StateCommon.Border.Width = 1;
            this.supervisor_update_list_update_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.supervisor_update_list_update_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.supervisor_update_list_update_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisor_update_list_update_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(250)))), ((int)(((byte)(138)))));
            this.supervisor_update_list_update_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(227)))), ((int)(((byte)(148)))));
            this.supervisor_update_list_update_btn.StatePressed.Back.ColorAngle = 135F;
            this.supervisor_update_list_update_btn.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.supervisor_update_list_update_btn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(250)))), ((int)(((byte)(138)))));
            this.supervisor_update_list_update_btn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(227)))), ((int)(((byte)(148)))));
            this.supervisor_update_list_update_btn.StatePressed.Border.ColorAngle = 135F;
            this.supervisor_update_list_update_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.supervisor_update_list_update_btn.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.supervisor_update_list_update_btn.StatePressed.Border.Rounding = 20;
            this.supervisor_update_list_update_btn.StatePressed.Border.Width = 1;
            this.supervisor_update_list_update_btn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.supervisor_update_list_update_btn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.supervisor_update_list_update_btn.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisor_update_list_update_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(250)))), ((int)(((byte)(138)))));
            this.supervisor_update_list_update_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(227)))), ((int)(((byte)(148)))));
            this.supervisor_update_list_update_btn.StateTracking.Back.ColorAngle = 45F;
            this.supervisor_update_list_update_btn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.supervisor_update_list_update_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(250)))), ((int)(((byte)(138)))));
            this.supervisor_update_list_update_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(227)))), ((int)(((byte)(148)))));
            this.supervisor_update_list_update_btn.StateTracking.Border.ColorAngle = 45F;
            this.supervisor_update_list_update_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.supervisor_update_list_update_btn.StateTracking.Border.Rounding = 20;
            this.supervisor_update_list_update_btn.StateTracking.Border.Width = 1;
            this.supervisor_update_list_update_btn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.supervisor_update_list_update_btn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.supervisor_update_list_update_btn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisor_update_list_update_btn.TabIndex = 43;
            this.supervisor_update_list_update_btn.Values.Text = "Update";
            this.supervisor_update_list_update_btn.Click += new System.EventHandler(this.supervisor_update_list_update_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Min Weight";
            // 
            // MinWeight_TextBox
            // 
            this.MinWeight_TextBox.Location = new System.Drawing.Point(209, 114);
            this.MinWeight_TextBox.Name = "MinWeight_TextBox";
            this.MinWeight_TextBox.Size = new System.Drawing.Size(193, 35);
            this.MinWeight_TextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MinWeight_TextBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MinWeight_TextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MinWeight_TextBox.StateCommon.Border.Rounding = 20;
            this.MinWeight_TextBox.StateCommon.Border.Width = 1;
            this.MinWeight_TextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.MinWeight_TextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinWeight_TextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.MinWeight_TextBox.TabIndex = 52;
            // 
            // MaxWeight_TextBox
            // 
            this.MaxWeight_TextBox.Location = new System.Drawing.Point(542, 114);
            this.MaxWeight_TextBox.Name = "MaxWeight_TextBox";
            this.MaxWeight_TextBox.Size = new System.Drawing.Size(193, 35);
            this.MaxWeight_TextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MaxWeight_TextBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MaxWeight_TextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MaxWeight_TextBox.StateCommon.Border.Rounding = 20;
            this.MaxWeight_TextBox.StateCommon.Border.Width = 1;
            this.MaxWeight_TextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.MaxWeight_TextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxWeight_TextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.MaxWeight_TextBox.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Max Weight";
            // 
            // supervisor_update_price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MaxWeight_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinWeight_TextBox);
            this.Controls.Add(this.supervisor_update_price_truck_type);
            this.Controls.Add(this.supervisor_update_price_unsuccessful_label);
            this.Controls.Add(this.supervisor_update_price_successful_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supervisor_update_price_new_price);
            this.Controls.Add(this.supervisor_update_list_update_btn);
            this.Controls.Add(this.label4);
            this.Name = "supervisor_update_price";
            this.Size = new System.Drawing.Size(800, 456);
            ((System.ComponentModel.ISupportInitialize)(this.supervisor_update_price_truck_type)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox supervisor_update_price_truck_type;
        private System.Windows.Forms.Label supervisor_update_price_unsuccessful_label;
        private System.Windows.Forms.Label supervisor_update_price_successful_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox supervisor_update_price_new_price;
        private ComponentFactory.Krypton.Toolkit.KryptonButton supervisor_update_list_update_btn;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox MinWeight_TextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox MaxWeight_TextBox;
        private System.Windows.Forms.Label label3;
    }
}
