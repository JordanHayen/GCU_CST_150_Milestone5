namespace InventoryManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AddStockButton = new System.Windows.Forms.Button();
            this.AddStockTextBox = new System.Windows.Forms.TextBox();
            this.EditSelected = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.InventoryDisplay = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.SearchResults = new System.Windows.Forms.ListBox();
            this.RemoveSelected = new System.Windows.Forms.Button();
            this.RemoveAllItem = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.LoadInventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddStockButton
            // 
            this.AddStockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(118)))), ((int)(((byte)(242)))));
            this.AddStockButton.ForeColor = System.Drawing.Color.White;
            this.AddStockButton.Location = new System.Drawing.Point(519, 340);
            this.AddStockButton.Name = "AddStockButton";
            this.AddStockButton.Size = new System.Drawing.Size(216, 35);
            this.AddStockButton.TabIndex = 32;
            this.AddStockButton.Text = "Add Stock";
            this.AddStockButton.UseVisualStyleBackColor = false;
            this.AddStockButton.Visible = false;
            this.AddStockButton.Click += new System.EventHandler(this.AddStockButton_Click);
            // 
            // AddStockTextBox
            // 
            this.AddStockTextBox.Location = new System.Drawing.Point(519, 381);
            this.AddStockTextBox.Name = "AddStockTextBox";
            this.AddStockTextBox.Size = new System.Drawing.Size(216, 20);
            this.AddStockTextBox.TabIndex = 31;
            this.AddStockTextBox.Visible = false;
            // 
            // EditSelected
            // 
            this.EditSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(118)))), ((int)(((byte)(242)))));
            this.EditSelected.ForeColor = System.Drawing.Color.White;
            this.EditSelected.Location = new System.Drawing.Point(519, 258);
            this.EditSelected.Name = "EditSelected";
            this.EditSelected.Size = new System.Drawing.Size(216, 35);
            this.EditSelected.TabIndex = 30;
            this.EditSelected.Text = "Edit Selected";
            this.EditSelected.UseVisualStyleBackColor = false;
            this.EditSelected.Visible = false;
            this.EditSelected.Click += new System.EventHandler(this.EditSelected_Click);
            // 
            // AddItem
            // 
            this.AddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(118)))), ((int)(((byte)(242)))));
            this.AddItem.ForeColor = System.Drawing.Color.White;
            this.AddItem.Location = new System.Drawing.Point(519, 176);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(216, 35);
            this.AddItem.TabIndex = 26;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = false;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // InventoryDisplay
            // 
            this.InventoryDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InventoryDisplay.FormattingEnabled = true;
            this.InventoryDisplay.ItemHeight = 20;
            this.InventoryDisplay.Items.AddRange(new object[] {
            "Item\t\tStock\t\tPrice"});
            this.InventoryDisplay.Location = new System.Drawing.Point(12, 23);
            this.InventoryDisplay.Name = "InventoryDisplay";
            this.InventoryDisplay.Size = new System.Drawing.Size(501, 384);
            this.InventoryDisplay.TabIndex = 33;
            this.InventoryDisplay.SelectedIndexChanged += new System.EventHandler(this.InventoryDisplay_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(519, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Search";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(519, 49);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(216, 20);
            this.SearchBar.TabIndex = 35;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // SearchResults
            // 
            this.SearchResults.FormattingEnabled = true;
            this.SearchResults.Location = new System.Drawing.Point(519, 75);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.Size = new System.Drawing.Size(216, 95);
            this.SearchResults.TabIndex = 36;
            this.SearchResults.SelectedIndexChanged += new System.EventHandler(this.SearchResults_SelectedIndexChanged);
            // 
            // RemoveSelected
            // 
            this.RemoveSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(118)))), ((int)(((byte)(242)))));
            this.RemoveSelected.ForeColor = System.Drawing.Color.White;
            this.RemoveSelected.Location = new System.Drawing.Point(519, 299);
            this.RemoveSelected.Name = "RemoveSelected";
            this.RemoveSelected.Size = new System.Drawing.Size(216, 35);
            this.RemoveSelected.TabIndex = 37;
            this.RemoveSelected.Text = "Remove Selected";
            this.RemoveSelected.UseVisualStyleBackColor = false;
            this.RemoveSelected.Visible = false;
            this.RemoveSelected.Click += new System.EventHandler(this.RemoveSelected_Click);
            // 
            // RemoveAllItem
            // 
            this.RemoveAllItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(118)))), ((int)(((byte)(242)))));
            this.RemoveAllItem.ForeColor = System.Drawing.Color.White;
            this.RemoveAllItem.Location = new System.Drawing.Point(519, 217);
            this.RemoveAllItem.Name = "RemoveAllItem";
            this.RemoveAllItem.Size = new System.Drawing.Size(216, 35);
            this.RemoveAllItem.TabIndex = 40;
            this.RemoveAllItem.Text = "Remove All";
            this.RemoveAllItem.UseVisualStyleBackColor = false;
            this.RemoveAllItem.Click += new System.EventHandler(this.RemoveAllItem_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(118)))), ((int)(((byte)(242)))));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(12, 413);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(240, 35);
            this.Save.TabIndex = 41;
            this.Save.Text = "Save Inventory";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // LoadInventory
            // 
            this.LoadInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(118)))), ((int)(((byte)(242)))));
            this.LoadInventory.ForeColor = System.Drawing.Color.White;
            this.LoadInventory.Location = new System.Drawing.Point(273, 413);
            this.LoadInventory.Name = "LoadInventory";
            this.LoadInventory.Size = new System.Drawing.Size(240, 35);
            this.LoadInventory.TabIndex = 42;
            this.LoadInventory.Text = "Load Inventory";
            this.LoadInventory.UseVisualStyleBackColor = false;
            this.LoadInventory.Click += new System.EventHandler(this.LoadInventory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(44)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(753, 460);
            this.Controls.Add(this.LoadInventory);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.RemoveAllItem);
            this.Controls.Add(this.RemoveSelected);
            this.Controls.Add(this.SearchResults);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InventoryDisplay);
            this.Controls.Add(this.AddStockButton);
            this.Controls.Add(this.AddStockTextBox);
            this.Controls.Add(this.EditSelected);
            this.Controls.Add(this.AddItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Inventory Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStockButton;
        private System.Windows.Forms.TextBox AddStockTextBox;
        private System.Windows.Forms.Button EditSelected;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.ListBox InventoryDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.ListBox SearchResults;
        private System.Windows.Forms.Button RemoveSelected;
        private System.Windows.Forms.Button RemoveAllItem;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button LoadInventory;
    }
}

