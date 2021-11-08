namespace InventoryManager
{
    partial class EditItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItemForm));
            this.Cancel = new System.Windows.Forms.Button();
            this.EditItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemPriceEditorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemStockEditorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemNameEditorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(207, 89);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(165, 33);
            this.Cancel.TabIndex = 43;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // EditItem
            // 
            this.EditItem.Location = new System.Drawing.Point(12, 89);
            this.EditItem.Name = "EditItem";
            this.EditItem.Size = new System.Drawing.Size(165, 33);
            this.EditItem.TabIndex = 42;
            this.EditItem.Text = "Edit Selected Item";
            this.EditItem.UseVisualStyleBackColor = true;
            this.EditItem.Click += new System.EventHandler(this.EditItem_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(272, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Item Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemPriceEditorTextBox
            // 
            this.ItemPriceEditorTextBox.Location = new System.Drawing.Point(272, 49);
            this.ItemPriceEditorTextBox.Name = "ItemPriceEditorTextBox";
            this.ItemPriceEditorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemPriceEditorTextBox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(142, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Item Stock";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemStockEditorTextBox
            // 
            this.ItemStockEditorTextBox.Location = new System.Drawing.Point(142, 49);
            this.ItemStockEditorTextBox.Name = "ItemStockEditorTextBox";
            this.ItemStockEditorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemStockEditorTextBox.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Item Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemNameEditorTextBox
            // 
            this.ItemNameEditorTextBox.Location = new System.Drawing.Point(12, 49);
            this.ItemNameEditorTextBox.Name = "ItemNameEditorTextBox";
            this.ItemNameEditorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemNameEditorTextBox.TabIndex = 36;
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.EditItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ItemPriceEditorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ItemStockEditorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemNameEditorTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditItemForm";
            this.Text = "EditItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button EditItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ItemPriceEditorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ItemStockEditorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemNameEditorTextBox;
    }
}