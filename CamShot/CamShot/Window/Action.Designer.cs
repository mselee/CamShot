namespace CamShot
{
    partial class Action
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
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Save", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Upload", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Disk");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Clipboard");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Imgur");
            this.btnDone = new System.Windows.Forms.Button();
            this.listActions = new System.Windows.Forms.ListView();
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDone.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDone.Location = new System.Drawing.Point(0, 176);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(246, 39);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // listActions
            // 
            this.listActions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listActions.CheckBoxes = true;
            this.listActions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column1});
            this.listActions.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup9.Header = "Save";
            listViewGroup9.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup9.Name = "gSave";
            listViewGroup10.Header = "Upload";
            listViewGroup10.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup10.Name = "gUpload";
            this.listActions.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup9,
            listViewGroup10});
            this.listActions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem13.Group = listViewGroup9;
            listViewItem13.StateImageIndex = 0;
            listViewItem14.Group = listViewGroup9;
            listViewItem14.StateImageIndex = 0;
            listViewItem15.Group = listViewGroup10;
            listViewItem15.StateImageIndex = 0;
            this.listActions.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15});
            this.listActions.Location = new System.Drawing.Point(0, 0);
            this.listActions.MultiSelect = false;
            this.listActions.Name = "listActions";
            this.listActions.Size = new System.Drawing.Size(246, 176);
            this.listActions.TabIndex = 7;
            this.listActions.UseCompatibleStateImageBehavior = false;
            this.listActions.View = System.Windows.Forms.View.Details;
            // 
            // column1
            // 
            this.column1.Text = "";
            this.column1.Width = 242;
            // 
            // pbox
            // 
            this.pbox.BackColor = System.Drawing.SystemColors.Window;
            this.pbox.Image = global::CamShot.Properties.Resources.load;
            this.pbox.Location = new System.Drawing.Point(0, 176);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(246, 39);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbox.TabIndex = 8;
            this.pbox.TabStop = false;
            this.pbox.Visible = false;
            // 
            // Action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(246, 215);
            this.ControlBox = false;
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.listActions);
            this.Controls.Add(this.btnDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Action";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ListView listActions;
        private System.Windows.Forms.ColumnHeader column1;
        private System.Windows.Forms.PictureBox pbox;

    }
}