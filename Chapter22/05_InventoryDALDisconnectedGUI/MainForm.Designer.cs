﻿namespace _05_InventoryDALDisconnectedGUI
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
      this.label1 = new System.Windows.Forms.Label();
      this.inventoryGrid = new System.Windows.Forms.DataGridView();
      this.btnUpdateInventory = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(385, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "INVENTORY";
      // 
      // inventoryGrid
      // 
      this.inventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.inventoryGrid.Location = new System.Drawing.Point(12, 58);
      this.inventoryGrid.Name = "inventoryGrid";
      this.inventoryGrid.Size = new System.Drawing.Size(858, 335);
      this.inventoryGrid.TabIndex = 1;
      // 
      // btnUpdateInventory
      // 
      this.btnUpdateInventory.Location = new System.Drawing.Point(360, 465);
      this.btnUpdateInventory.Name = "btnUpdateInventory";
      this.btnUpdateInventory.Size = new System.Drawing.Size(134, 23);
      this.btnUpdateInventory.TabIndex = 2;
      this.btnUpdateInventory.Text = "Update Database";
      this.btnUpdateInventory.UseVisualStyleBackColor = true;
      this.btnUpdateInventory.Click += new System.EventHandler(this.btnUpdateInventory_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(882, 557);
      this.Controls.Add(this.btnUpdateInventory);
      this.Controls.Add(this.inventoryGrid);
      this.Controls.Add(this.label1);
      this.Name = "MainForm";
      this.Text = "MainForm";
      ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView inventoryGrid;
    private System.Windows.Forms.Button btnUpdateInventory;
  }
}

