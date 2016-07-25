﻿namespace _04_AutoLotEDM_GUI
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
      this.gridInventory = new System.Windows.Forms.DataGridView();
      this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.petNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ordersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnUpdate = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.gridInventory)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // gridInventory
      // 
      this.gridInventory.AutoGenerateColumns = false;
      this.gridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIdDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.petNameDataGridViewTextBoxColumn,
            this.ordersDataGridViewTextBoxColumn});
      this.gridInventory.DataSource = this.inventoryBindingSource;
      this.gridInventory.Location = new System.Drawing.Point(0, 0);
      this.gridInventory.Name = "gridInventory";
      this.gridInventory.Size = new System.Drawing.Size(554, 150);
      this.gridInventory.TabIndex = 0;
      // 
      // inventoryBindingSource
      // 
      this.inventoryBindingSource.DataSource = typeof(AutoLotDAL.Inventory);
      // 
      // carIdDataGridViewTextBoxColumn
      // 
      this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
      this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
      this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
      // 
      // makeDataGridViewTextBoxColumn
      // 
      this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
      this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
      this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
      // 
      // colorDataGridViewTextBoxColumn
      // 
      this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
      this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
      this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
      // 
      // petNameDataGridViewTextBoxColumn
      // 
      this.petNameDataGridViewTextBoxColumn.DataPropertyName = "PetName";
      this.petNameDataGridViewTextBoxColumn.HeaderText = "PetName";
      this.petNameDataGridViewTextBoxColumn.Name = "petNameDataGridViewTextBoxColumn";
      // 
      // ordersDataGridViewTextBoxColumn
      // 
      this.ordersDataGridViewTextBoxColumn.DataPropertyName = "Orders";
      this.ordersDataGridViewTextBoxColumn.HeaderText = "Orders";
      this.ordersDataGridViewTextBoxColumn.Name = "ordersDataGridViewTextBoxColumn";
      // 
      // btnUpdate
      // 
      this.btnUpdate.Location = new System.Drawing.Point(12, 239);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(75, 23);
      this.btnUpdate.TabIndex = 1;
      this.btnUpdate.Text = "Update!";
      this.btnUpdate.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(566, 274);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.gridInventory);
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridInventory)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView gridInventory;
    private System.Windows.Forms.DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn petNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource inventoryBindingSource;
    private System.Windows.Forms.Button btnUpdate;
  }
}

