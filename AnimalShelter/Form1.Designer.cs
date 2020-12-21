
namespace AnimalShelter
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CusQualified = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CusDescription = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CusAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CusAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CusFisrtName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CusLastName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labe15 = new System.Windows.Forms.Label();
            this.InputNote = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.InputAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.InputBirthday = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.InputLastName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.InputFirstName = new System.Windows.Forms.TextBox();
            this.CusListPanel = new System.Windows.Forms.Panel();
            this.CusListView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.CusListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CusListView)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Location = new System.Drawing.Point(181, 258);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(127, 35);
            this.CreateCustomer.TabIndex = 0;
            this.CreateCustomer.Text = "  입양자 생성";
            this.CreateCustomer.UseVisualStyleBackColor = true;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CusQualified);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CusDescription);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CusAddress);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CusAge);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CusFisrtName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CusLastName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(400, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 224);
            this.panel1.TabIndex = 1;
            // 
            // CusQualified
            // 
            this.CusQualified.AutoSize = true;
            this.CusQualified.Location = new System.Drawing.Point(277, 20);
            this.CusQualified.Name = "CusQualified";
            this.CusQualified.Size = new System.Drawing.Size(45, 15);
            this.CusQualified.TabIndex = 11;
            this.CusQualified.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "입양가능여부 : ";
            // 
            // CusDescription
            // 
            this.CusDescription.AutoSize = true;
            this.CusDescription.Location = new System.Drawing.Point(71, 153);
            this.CusDescription.Name = "CusDescription";
            this.CusDescription.Size = new System.Drawing.Size(45, 15);
            this.CusDescription.TabIndex = 9;
            this.CusDescription.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "설명 : ";
            // 
            // CusAddress
            // 
            this.CusAddress.AutoSize = true;
            this.CusAddress.Location = new System.Drawing.Point(71, 120);
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.Size = new System.Drawing.Size(45, 15);
            this.CusAddress.TabIndex = 7;
            this.CusAddress.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "주소 : ";
            // 
            // CusAge
            // 
            this.CusAge.AutoSize = true;
            this.CusAge.Location = new System.Drawing.Point(71, 83);
            this.CusAge.Name = "CusAge";
            this.CusAge.Size = new System.Drawing.Size(45, 15);
            this.CusAge.TabIndex = 5;
            this.CusAge.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "나이 : ";
            // 
            // CusFisrtName
            // 
            this.CusFisrtName.AutoSize = true;
            this.CusFisrtName.Location = new System.Drawing.Point(71, 50);
            this.CusFisrtName.Name = "CusFisrtName";
            this.CusFisrtName.Size = new System.Drawing.Size(45, 15);
            this.CusFisrtName.TabIndex = 3;
            this.CusFisrtName.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "이름 : ";
            // 
            // CusLastName
            // 
            this.CusLastName.AutoSize = true;
            this.CusLastName.Location = new System.Drawing.Point(71, 20);
            this.CusLastName.Name = "CusLastName";
            this.CusLastName.Size = new System.Drawing.Size(45, 15);
            this.CusLastName.TabIndex = 1;
            this.CusLastName.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "성 : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labe15);
            this.panel2.Controls.Add(this.InputNote);
            this.panel2.Controls.Add(this.CreateCustomer);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.InputAddress);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.InputBirthday);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.InputLastName);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.InputFirstName);
            this.panel2.Location = new System.Drawing.Point(24, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 316);
            this.panel2.TabIndex = 2;
            // 
            // labe15
            // 
            this.labe15.AutoSize = true;
            this.labe15.Location = new System.Drawing.Point(3, 139);
            this.labe15.Name = "labe15";
            this.labe15.Size = new System.Drawing.Size(37, 15);
            this.labe15.TabIndex = 9;
            this.labe15.Text = "설명";
            // 
            // InputNote
            // 
            this.InputNote.Location = new System.Drawing.Point(66, 136);
            this.InputNote.Multiline = true;
            this.InputNote.Name = "InputNote";
            this.InputNote.Size = new System.Drawing.Size(242, 103);
            this.InputNote.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 7;
            this.label14.Text = "주소";
            // 
            // InputAddress
            // 
            this.InputAddress.Location = new System.Drawing.Point(66, 105);
            this.InputAddress.Name = "InputAddress";
            this.InputAddress.Size = new System.Drawing.Size(242, 25);
            this.InputAddress.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "생일";
            // 
            // InputBirthday
            // 
            this.InputBirthday.Location = new System.Drawing.Point(66, 74);
            this.InputBirthday.Name = "InputBirthday";
            this.InputBirthday.Size = new System.Drawing.Size(117, 25);
            this.InputBirthday.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "이름";
            // 
            // InputLastName
            // 
            this.InputLastName.Location = new System.Drawing.Point(66, 43);
            this.InputLastName.Name = "InputLastName";
            this.InputLastName.Size = new System.Drawing.Size(117, 25);
            this.InputLastName.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "성";
            // 
            // InputFirstName
            // 
            this.InputFirstName.Location = new System.Drawing.Point(66, 12);
            this.InputFirstName.Name = "InputFirstName";
            this.InputFirstName.Size = new System.Drawing.Size(117, 25);
            this.InputFirstName.TabIndex = 0;
            // 
            // CusListPanel
            // 
            this.CusListPanel.Controls.Add(this.CusListView);
            this.CusListPanel.Location = new System.Drawing.Point(366, 258);
            this.CusListPanel.Name = "CusListPanel";
            this.CusListPanel.Size = new System.Drawing.Size(407, 180);
            this.CusListPanel.TabIndex = 3;
            // 
            // CusListView
            // 
            this.CusListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CusListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.CusListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CusListView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CusListView.Location = new System.Drawing.Point(0, 0);
            this.CusListView.Name = "CusListView";
            this.CusListView.RowHeadersWidth = 51;
            this.CusListView.RowTemplate.Height = 27;
            this.CusListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CusListView.Size = new System.Drawing.Size(407, 180);
            this.CusListView.TabIndex = 0;
            this.CusListView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CusListView_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "이름";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "나이";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "입양가능";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CusListPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.CusListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CusListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CusLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CusAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CusFisrtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CusDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CusAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CusQualified;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labe15;
        private System.Windows.Forms.TextBox InputNote;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox InputAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox InputBirthday;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox InputLastName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox InputFirstName;
        private System.Windows.Forms.Panel CusListPanel;
        private System.Windows.Forms.DataGridView CusListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

