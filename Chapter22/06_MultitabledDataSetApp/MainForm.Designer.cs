namespace _06_MultitabledDataSetApp
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
      this.btnUpdateDatabase = new System.Windows.Forms.Button();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.txtCustId = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnGetOrderInfo = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
      this.groupBox4.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dataGridViewInventory);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(2, 1);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(800, 200);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Current Inventory";
      // 
      // dataGridViewInventory
      // 
      this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewInventory.DefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridViewInventory.Location = new System.Drawing.Point(11, 22);
      this.dataGridViewInventory.Name = "dataGridViewInventory";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridViewInventory.Size = new System.Drawing.Size(775, 175);
      this.dataGridViewInventory.TabIndex = 0;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.dataGridViewCustomers);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.Location = new System.Drawing.Point(2, 224);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(800, 200);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Current Customers";
      // 
      // dataGridViewCustomers
      // 
      this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewCustomers.DefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridViewCustomers.Location = new System.Drawing.Point(11, 22);
      this.dataGridViewCustomers.Name = "dataGridViewCustomers";
      this.dataGridViewCustomers.Size = new System.Drawing.Size(775, 175);
      this.dataGridViewCustomers.TabIndex = 0;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.dataGridViewOrders);
      this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox3.Location = new System.Drawing.Point(2, 453);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(800, 200);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Current Orders";
      // 
      // dataGridViewOrders
      // 
      this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewOrders.DefaultCellStyle = dataGridViewCellStyle4;
      this.dataGridViewOrders.Location = new System.Drawing.Point(11, 22);
      this.dataGridViewOrders.Name = "dataGridViewOrders";
      this.dataGridViewOrders.Size = new System.Drawing.Size(775, 175);
      this.dataGridViewOrders.TabIndex = 0;
      // 
      // btnUpdateDatabase
      // 
      this.btnUpdateDatabase.Location = new System.Drawing.Point(668, 673);
      this.btnUpdateDatabase.Name = "btnUpdateDatabase";
      this.btnUpdateDatabase.Size = new System.Drawing.Size(120, 28);
      this.btnUpdateDatabase.TabIndex = 3;
      this.btnUpdateDatabase.Text = "Update Database";
      this.btnUpdateDatabase.UseVisualStyleBackColor = true;
      this.btnUpdateDatabase.Click += new System.EventHandler(this.btnUpdateDatabase_Click);
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.btnGetOrderInfo);
      this.groupBox4.Controls.Add(this.label1);
      this.groupBox4.Controls.Add(this.txtCustId);
      this.groupBox4.Location = new System.Drawing.Point(13, 673);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(200, 100);
      this.groupBox4.TabIndex = 4;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Lookup Customer Order";
      // 
      // txtCustId
      // 
      this.txtCustId.Location = new System.Drawing.Point(94, 26);
      this.txtCustId.Name = "txtCustId";
      this.txtCustId.Size = new System.Drawing.Size(100, 20);
      this.txtCustId.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Customer Id";
      // 
      // btnGetOrderInfo
      // 
      this.btnGetOrderInfo.Location = new System.Drawing.Point(94, 71);
      this.btnGetOrderInfo.Name = "btnGetOrderInfo";
      this.btnGetOrderInfo.Size = new System.Drawing.Size(100, 23);
      this.btnGetOrderInfo.TabIndex = 2;
      this.btnGetOrderInfo.Text = "Get Order Details";
      this.btnGetOrderInfo.UseVisualStyleBackColor = true;
      this.btnGetOrderInfo.Click += new System.EventHandler(this.btnGetOrderInfo_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(808, 806);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.btnUpdateDatabase);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "MainForm";
      this.Text = "Main Form";
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
      this.groupBox3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView dataGridViewInventory;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridView dataGridViewCustomers;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.DataGridView dataGridViewOrders;
    private System.Windows.Forms.Button btnUpdateDatabase;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Button btnGetOrderInfo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtCustId;
  }
}

