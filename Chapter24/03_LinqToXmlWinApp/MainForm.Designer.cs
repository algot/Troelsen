namespace _03_LinqToXmlWinApp
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
      this.txtInventory = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnAddNewItem = new System.Windows.Forms.Button();
      this.lblPetName = new System.Windows.Forms.Label();
      this.lblColor = new System.Windows.Forms.Label();
      this.llbMake = new System.Windows.Forms.Label();
      this.txtPetName = new System.Windows.Forms.TextBox();
      this.txtColor = new System.Windows.Forms.TextBox();
      this.txtMake = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnLookUpColors = new System.Windows.Forms.Button();
      this.txtMakeToLookUp = new System.Windows.Forms.TextBox();
      this.lblLookUp = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtInventory
      // 
      this.txtInventory.Location = new System.Drawing.Point(14, 14);
      this.txtInventory.Multiline = true;
      this.txtInventory.Name = "txtInventory";
      this.txtInventory.ReadOnly = true;
      this.txtInventory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtInventory.Size = new System.Drawing.Size(583, 346);
      this.txtInventory.TabIndex = 0;
      this.txtInventory.TabStop = false;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnAddNewItem);
      this.groupBox1.Controls.Add(this.lblPetName);
      this.groupBox1.Controls.Add(this.lblColor);
      this.groupBox1.Controls.Add(this.llbMake);
      this.groupBox1.Controls.Add(this.txtPetName);
      this.groupBox1.Controls.Add(this.txtColor);
      this.groupBox1.Controls.Add(this.txtMake);
      this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(660, 14);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(467, 260);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Add Inventory Item";
      // 
      // btnAddNewItem
      // 
      this.btnAddNewItem.Location = new System.Drawing.Point(372, 204);
      this.btnAddNewItem.Name = "btnAddNewItem";
      this.btnAddNewItem.Size = new System.Drawing.Size(87, 27);
      this.btnAddNewItem.TabIndex = 4;
      this.btnAddNewItem.Text = "Add";
      this.btnAddNewItem.UseVisualStyleBackColor = true;
      this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
      // 
      // lblPetName
      // 
      this.lblPetName.AutoSize = true;
      this.lblPetName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPetName.Location = new System.Drawing.Point(8, 148);
      this.lblPetName.Name = "lblPetName";
      this.lblPetName.Size = new System.Drawing.Size(58, 15);
      this.lblPetName.TabIndex = 3;
      this.lblPetName.Text = "Pet Name";
      // 
      // lblColor
      // 
      this.lblColor.AutoSize = true;
      this.lblColor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblColor.Location = new System.Drawing.Point(8, 99);
      this.lblColor.Name = "lblColor";
      this.lblColor.Size = new System.Drawing.Size(37, 15);
      this.lblColor.TabIndex = 3;
      this.lblColor.Text = "Color";
      // 
      // llbMake
      // 
      this.llbMake.AutoSize = true;
      this.llbMake.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.llbMake.Location = new System.Drawing.Point(8, 52);
      this.llbMake.Name = "llbMake";
      this.llbMake.Size = new System.Drawing.Size(37, 15);
      this.llbMake.TabIndex = 3;
      this.llbMake.Text = "Make";
      // 
      // txtPetName
      // 
      this.txtPetName.Location = new System.Drawing.Point(104, 140);
      this.txtPetName.Name = "txtPetName";
      this.txtPetName.Size = new System.Drawing.Size(355, 23);
      this.txtPetName.TabIndex = 2;
      // 
      // txtColor
      // 
      this.txtColor.Location = new System.Drawing.Point(104, 91);
      this.txtColor.Name = "txtColor";
      this.txtColor.Size = new System.Drawing.Size(355, 23);
      this.txtColor.TabIndex = 1;
      // 
      // txtMake
      // 
      this.txtMake.Location = new System.Drawing.Point(104, 45);
      this.txtMake.Name = "txtMake";
      this.txtMake.Size = new System.Drawing.Size(355, 23);
      this.txtMake.TabIndex = 0;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btnLookUpColors);
      this.groupBox2.Controls.Add(this.txtMakeToLookUp);
      this.groupBox2.Controls.Add(this.lblLookUp);
      this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.Location = new System.Drawing.Point(660, 280);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(467, 202);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Look Up Colors for Make";
      // 
      // btnLookUpColors
      // 
      this.btnLookUpColors.Location = new System.Drawing.Point(226, 147);
      this.btnLookUpColors.Name = "btnLookUpColors";
      this.btnLookUpColors.Size = new System.Drawing.Size(232, 23);
      this.btnLookUpColors.TabIndex = 2;
      this.btnLookUpColors.Text = "Look Up Colors";
      this.btnLookUpColors.UseVisualStyleBackColor = true;
      this.btnLookUpColors.Click += new System.EventHandler(this.btnLookUpColors_Click);
      // 
      // txtMakeToLookUp
      // 
      this.txtMakeToLookUp.Location = new System.Drawing.Point(226, 80);
      this.txtMakeToLookUp.Name = "txtMakeToLookUp";
      this.txtMakeToLookUp.Size = new System.Drawing.Size(233, 23);
      this.txtMakeToLookUp.TabIndex = 1;
      // 
      // lblLookUp
      // 
      this.lblLookUp.AutoSize = true;
      this.lblLookUp.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLookUp.Location = new System.Drawing.Point(8, 83);
      this.lblLookUp.Name = "lblLookUp";
      this.lblLookUp.Size = new System.Drawing.Size(98, 15);
      this.lblLookUp.TabIndex = 0;
      this.lblLookUp.Text = "Make To Look Up";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1176, 647);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.txtInventory);
      this.Font = new System.Drawing.Font("Calibri", 10F);
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtInventory;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnAddNewItem;
    private System.Windows.Forms.Label lblPetName;
    private System.Windows.Forms.Label lblColor;
    private System.Windows.Forms.Label llbMake;
    private System.Windows.Forms.TextBox txtPetName;
    private System.Windows.Forms.TextBox txtColor;
    private System.Windows.Forms.TextBox txtMake;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox txtMakeToLookUp;
    private System.Windows.Forms.Label lblLookUp;
    private System.Windows.Forms.Button btnLookUpColors;
  }
}

