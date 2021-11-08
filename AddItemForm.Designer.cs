namespace InventoryManager
{
    partial class AddItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemForm));
            this.AddItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemStockTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(12, 89);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(165, 33);
            this.AddItem.TabIndex = 33;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(272, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Item Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemPriceTextBox
            // 
            this.ItemPriceTextBox.Location = new System.Drawing.Point(272, 49);
            this.ItemPriceTextBox.Name = "ItemPriceTextBox";
            this.ItemPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemPriceTextBox.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(142, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Item Stock";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemStockTextBox
            // 
            this.ItemStockTextBox.Location = new System.Drawing.Point(142, 49);
            this.ItemStockTextBox.Name = "ItemStockTextBox";
            this.ItemStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemStockTextBox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Item Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(12, 49);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemNameTextBox.TabIndex = 27;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(207, 89);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(165, 33);
            this.Cancel.TabIndex = 35;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ItemPriceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ItemStockTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddItemForm";
            this.Text = "Add Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ItemPriceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ItemStockTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.Button Cancel;
    }
}