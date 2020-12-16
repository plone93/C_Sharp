
namespace WindowsFormsApp_Study1
{
    partial class Calculator
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
            this.Numbutton1 = new System.Windows.Forms.Button();
            this.Numbutton2 = new System.Windows.Forms.Button();
            this.NumScreen = new System.Windows.Forms.Label();
            this.Plusbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Numbutton1
            // 
            this.Numbutton1.Location = new System.Drawing.Point(22, 140);
            this.Numbutton1.Name = "Numbutton1";
            this.Numbutton1.Size = new System.Drawing.Size(75, 72);
            this.Numbutton1.TabIndex = 0;
            this.Numbutton1.Text = "1";
            this.Numbutton1.UseVisualStyleBackColor = true;
            this.Numbutton1.Click += new System.EventHandler(this.Numbutton1_Click);
            // 
            // Numbutton2
            // 
            this.Numbutton2.Location = new System.Drawing.Point(103, 140);
            this.Numbutton2.Name = "Numbutton2";
            this.Numbutton2.Size = new System.Drawing.Size(75, 72);
            this.Numbutton2.TabIndex = 1;
            this.Numbutton2.Text = "2";
            this.Numbutton2.UseVisualStyleBackColor = true;
            this.Numbutton2.Click += new System.EventHandler(this.Numbutton2_Click);
            // 
            // NumScreen
            // 
            this.NumScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumScreen.Location = new System.Drawing.Point(22, 13);
            this.NumScreen.Name = "NumScreen";
            this.NumScreen.Size = new System.Drawing.Size(1059, 104);
            this.NumScreen.TabIndex = 2;
            this.NumScreen.Text = "0";
            this.NumScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Plusbutton
            // 
            this.Plusbutton.Location = new System.Drawing.Point(1006, 140);
            this.Plusbutton.Name = "Plusbutton";
            this.Plusbutton.Size = new System.Drawing.Size(75, 72);
            this.Plusbutton.TabIndex = 3;
            this.Plusbutton.Text = "+";
            this.Plusbutton.UseVisualStyleBackColor = true;
            this.Plusbutton.Click += new System.EventHandler(this.Plusbutton_Click);
            // 
            // Calculator
            // 
            this.ClientSize = new System.Drawing.Size(1105, 535);
            this.Controls.Add(this.Plusbutton);
            this.Controls.Add(this.NumScreen);
            this.Controls.Add(this.Numbutton2);
            this.Controls.Add(this.Numbutton1);
            this.Font = new System.Drawing.Font("굴림", 12F);
            this.Name = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Numbutton1;
        private System.Windows.Forms.Button Numbutton2;
        private System.Windows.Forms.Label NumScreen;
        private System.Windows.Forms.Button Plusbutton;
    }
}

